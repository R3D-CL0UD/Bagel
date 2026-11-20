using System;
using System.Text;
using System.Threading;

class Donut
{
    static void Main()
    {
        float A = 0, B = 0, i, j;
        float[] z = new float[1760];
        char[] b = new char[1760];
        var sb = new StringBuilder(2000);

        Console.Write("\x1b[2J");

        while (true)
        {
            Array.Fill(b, ' ');
            Array.Clear(z, 0, z.Length);
            sb.Clear();

            for (j = 0; j < 6.28f; j += 0.07f)
            {
                for (i = 0; i < 6.28f; i += 0.02f)
                {
                    float c = (float)Math.Sin(i);
                    float d = (float)Math.Cos(j);
                    float e = (float)Math.Sin(A);
                    float f = (float)Math.Sin(j);
                    float g = (float)Math.Cos(A);
                    float h = d + 2;
                    float D = 1f / (c * h * e + f * g + 5);
                    float l = (float)Math.Cos(i);
                    float m = (float)Math.Cos(B);
                    float n = (float)Math.Sin(B);
                    float t = c * h * g - f * e;

                    int x = (int)(40 + 30 * D * (l * h * m - t * n));
                    int y = (int)(12 + 15 * D * (l * h * n + t * m));
                    int o = x + 80 * y;
                    int N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));

                    if (y > 0 && y < 22 && x > 0 && x < 80 && D > z[o])
                    {
                        z[o] = D;
                        b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                    }
                }
            }

            sb.Append("\x1b[H");
            for (int k = 0; k < 1761; k++)
            {
                sb.Append(k % 80 != 0 ? b[k] : '\n');
            }
            Console.Write(sb.ToString());

            A += 0.04f;
            B += 0.02f;
            Thread.Sleep(20);
        }
    }
}