using System;
using System.Threading;
using System.Windows.Forms;


namespace LZTMacro_Rust
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread recoil_thread = new Thread(Recoil);
            recoil_thread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Macro());
        }
        static void Recoil()
        {
            while (true)
            {
                try
                {
                    if (Macro.activ && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
                    {
                        for (int i = 0; i < Weapons.Current_weapon().Item1.Length; i++)
                        {
                            double Recoil_x = ((Weapons.Current_weapon().Item1[i, 0] / 2) / Macro.sense) * Weapons.Attachment().Item1 * Weapons.Scope();
                            double Recoil_y = ((Weapons.Current_weapon().Item1[i, 1] / 2) / Macro.sense) * Weapons.Attachment().Item1 * Weapons.Scope();

                            for (int j = 0; j < Macro.smooth; j++)
                            {
                                if (!Mouse.IsKeyDown(Keys.LButton) || !Mouse.IsKeyDown(Keys.RButton))
                                {
                                    continue;
                                }
                                int move_x = Convert.ToInt32(Recoil_x / Macro.smooth);
                                int move_y = Convert.ToInt32(Recoil_y / Macro.smooth);

                                if (Macro.minmax)
                                {
                                    move_x = Weapons.minmax(move_x, Macro.min, Macro.max);
                                    move_y = Weapons.minmax(move_y, Macro.min, Macro.max);
                                }


                                Mouse.RelativeMove(move_x, move_y);


                                double sleep = (Weapons.Current_weapon().Item2 / Macro.smooth) * Weapons.Attachment().Item2;
                                Thread.Sleep(Convert.ToInt32(sleep));
                            }
                            if (Macro.test1 && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
                            {
                                int lost_x = Convert.ToInt32(Recoil_x % Macro.smooth);
                                int lost_y = Convert.ToInt32(Recoil_y % Macro.smooth);

                                Mouse.RelativeMove(lost_x, lost_y);

                            }
                        }
                    }
                }
                catch { }
            }
        }

    }
}
