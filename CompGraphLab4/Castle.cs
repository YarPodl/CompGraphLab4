using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace CompGraphLab4
{
    /// <summary>
    /// Класс для отрисовки замка
    /// </summary>
    class Castle
    {
        /// <summary>
        /// Содержит все отрисовываемые объекты
        /// </summary>
        DrawingObject[] drawingObjects;

        /// <summary>
        /// Создает отрисовываемые объекты
        /// </summary>
        public Castle()
        {
            DrawingObject wall1a = new DrawingObject()
            {
                Matrix = new int[,]
                {
                    { -7,   0,      15,   1},
                    { 7,    0,      15,   1},
                    { 7,    0,      15,   1},
                    { 7,    -14,    15,   1},
                    { 7,    -14,    15,   1},
                    { -7,   -14,    15,   1},
                    { -7,   -14,    15,   1},
                    { -7,     0,    15,   1},
                }
            };
            DrawingObject wall1b = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -7,   0,      14,   1},
                    { 7,    0,      14,   1},
                    { 7,    0,      14,   1},
                    { 7,    -14,    14,   1},
                    { 7,    -14,    14,   1},
                    { -7,   -14,    14,   1},
                    { -7,   -14,    14,   1},
                    { -7,     0,    14,   1},

                }
            };
            DrawingObject wall1c = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -7,     0,    14,   1},
                    { -7,     0,    15,   1},
                    {  7,     0,    14,   1},
                    {  7,     0,    15,   1},

                }
            };
            DrawingObject wall2a = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -7,   0,      -15,   1},
                    { 7,    0,      -15,   1},
                    { 7,    0,      -15,   1},
                    { 7,    -14,    -15,   1},
                    { 7,    -14,    -15,   1},
                    { 4,    -14,    -15,   1},
                    { 4,    -14,    -15,   1},
                    { 4,    -4,     -15,   1},
                    { 4,    -4,     -15,   1},
                    { -4,   -4,     -15,   1},
                    { -4,   -4,     -15,   1},
                    { -4,   -14,    -15,   1},
                    { -4,   -14,    -15,   1},
                    { -7,   -14,    -15,   1},
                    { -7,   -14,    -15,   1},
                    { -7,     0,    -15,   1},

                }
            };
            DrawingObject wall2b = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -7,   0,      -14,   1},
                    { 7,    0,      -14,   1},
                    { 7,    0,      -14,   1},
                    { 7,    -14,    -14,   1},
                    { 7,    -14,    -14,   1},
                    { 4,    -14,    -14,   1},
                    { 4,    -14,    -14,   1},
                    { 4,    -4,     -14,   1},
                    { 4,    -4,     -14,   1},
                    { -4,   -4,     -14,   1},
                    { -4,   -4,     -14,   1},
                    { -4,   -14,    -14,   1},
                    { -4,   -14,    -14,   1},
                    { -7,   -14,    -14,   1},
                    { -7,   -14,    -14,   1},
                    { -7,     0,    -14,   1},

                }
            };
            DrawingObject wall2c = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -7,     0,    -14,   1},
                    { -7,     0,    -15,   1},
                    {  7,     0,    -14,   1},
                    {  7,     0,    -15,   1},

                }
            };
            DrawingObject wall3a = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -15,   0,      -7,   1},
                    { -15,   0,      7,    1},
                    { -15,   0,      7,    1},
                    { -15,   -14,    7,    1},
                    { -15,   -14,    7,    1},
                    { -15,   -14,    -7,   1},
                    { -15,   -14,    -7,   1},
                    { -15,     0,    -7,   1},

                }
            };
            DrawingObject wall3b = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -14,   0,      -7,   1},
                    { -14,   0,      7,    1},
                    { -14,   0,      7,    1},
                    { -14,   -14,    7,    1},
                    { -14,   -14,    7,    1},
                    { -14,   -14,    -7,   1},
                    { -14,   -14,    -7,   1},
                    { -14,     0,    -7,   1},

                }
            };
            DrawingObject wall3c = new DrawingObject()
            {
                Matrix = new int[,]{
                    { -14,     0,    -7,   1},
                    { -15,     0,    -7,   1},
                    { -14,     0,     7,   1},
                    { -15,     0,     7,   1},
                }
            };
            DrawingObject wall4a = new DrawingObject()
            {
                Matrix = new int[,]{
                    { 15,   0,      -7,   1},
                    { 15,   0,      7,    1},
                    { 15,   0,      7,    1},
                    { 15,   -14,    7,    1},
                    { 15,   -14,    7,    1},
                    { 15,   -14,    -7,   1},
                    { 15,   -14,    -7,   1},
                    { 15,     0,    -7,   1},

                }
            };
            DrawingObject wall4b = new DrawingObject()
            {
                Matrix = new int[,]{
                    { 14,   0,      -7,   1},
                    { 14,   0,      7,    1},
                    { 14,   0,      7,    1},
                    { 14,   -14,    7,    1},
                    { 14,   -14,    7,    1},
                    { 14,   -14,    -7,   1},
                    { 14,   -14,    -7,   1},
                    { 14,     0,    -7,   1},

                }
            };
            DrawingObject wall4c = new DrawingObject()
            {
                Matrix = new int[,]{
                    { 14,     0,    -7,   1},
                    { 15,     0,    -7,   1},
                    { 14,     0,     7,   1},
                    { 15,     0,     7,   1},
                }
            };
            DrawingObject flag = new DrawingObject()
            {
                Matrix = new int[,]{
                { 11, 8,  15,     1},
                { 11, 14, 15,     1},
                { 11, 14, 15,     1},
                { 13, 13, 15,     1},
                { 13, 13, 15,     1},
                { 11, 12, 15,     1}
            }
            };

            drawingObjects = new DrawingObject[]
            {
                new Tower(-15,  0,  7  ),
                new Tower(-15,  0,  -15),
                new Tower(  7,  0,  7  ),
                new Tower(  7,  0,  -15),
                wall1a,
                wall2b,
                wall3c,
                wall4a,
                wall1b,
                wall2c,
                wall3a,
                wall4b,
                wall1c,
                wall2a,
                wall3b,
                wall4c,
                flag,
                new Window(-12, 6, 15),
                new Window(10, 6, 15),
                new Window(-12, -4, 15),
                new Window(10, -4, 15),
                new Window(-12, 6, -15),
                new Window(10, 6, -15),
                new Window(-12, -4, -15),
                new Window(10, -4, -15),
            };
        }


        /// <summary>
        /// Рисует замок
        /// </summary>
        /// <param name="graphics">Рисующий объект</param>
        /// <param name="zoom">Масштаб</param>
        /// <param name="rotationX">Угол поворота вокруг оси X</param>
        /// <param name="rotationY">Угол поворота вокруг оси Y</param>
        /// <param name="rotationZ">Угол поворота вокруг оси Z</param>
        /// <param name="moveX">Перемещение по оси X</param>
        /// <param name="moveY">Перемещение по оси Y</param>
        /// <param name="moveZ">Перемещение по оси Z</param>
        /// <param name="alpha">Угол поворота для проекции</param>
        /// <param name="f">Коэффециент сжатия для проекции</param>
        public void Draw(Graphics graphics, int zoom,
            int rotationX, int rotationY, int rotationZ,
            int moveX, int moveY, int moveZ, int alpha, int f)
        {
            /// Угол поворота в радианах
            double angleX = rotationX * PI / 180;
            double angleY = rotationY * PI / 180;
            double angleZ = rotationZ * PI / 180;
            double angleAlpha = alpha * PI / 180;
            /// Матрица для поворота вокруг оси X
            double[,] T1 =
            {
                { 1,             0,             0,    0},  
                { 0,   Cos(angleX),     Sin(angleX),  0},
                { 0,   -Sin(angleX),    Cos(angleX),  0},
                { 0,             0,             0,    1}
            };
            
            /// Матрица для масшабирования
            double[,] T2 =
            {
                { (double)zoom / 10,    0,   0,     0},
                { 0,    (double)zoom / 10,   0,     0},
                { 0,    0,   (double)zoom / 10,     0},
                { 0,    0,   0,     1}
            };
            /// Матрица для перемещения
            double[,] T4 =
            {
                { 1,     0,     0,     0},
                { 0,     1,     0,     0},
                { 0,     0,     1,     0},
                { moveX, moveY, moveZ, 1},
            };
            /// Матрица для поворота вокруг оси Y
            double[,] T5 =
            {
                { Cos(angleY),    0,    -Sin(angleY),  0},
                { 0,              1,              0,  0},
                { Sin(angleY),    0,    Cos(angleY),  0},
                { 0,              0,              0,  1}
            };
            /// Матрица для поворота вокруг оси Z
            double[,] T6 =
            {
                { Cos(angleZ),    Sin(angleZ),    0,  0},
                { -Sin(angleZ),   Cos(angleZ),    0,  0},
                { 0,             0,               1,  0},
                { 0,             0,               0,  1}
            };
            /// Матрица для косоугольной проекции
            double[,] T7 =
            {
                { 1,                          0,                            0,  0},
                { 0,                          1,                            0,  0},
                { -f * Cos(angleAlpha) / 100, -f * Sin(angleAlpha) / 100,   0,  0},
                { 0,                          0,                            0,  1}
            };
            /// Итоговая матрица
            double[,] T = Multiply(Multiply(Multiply(Multiply(Multiply(T1, T2), T4), T5), T6), T7);  
            foreach (var i in drawingObjects)
            {
                i.Draw(graphics, T);
            }
        }

        public void CalculateRatio()
        {
            foreach (var item in drawingObjects)
            {
                item.CalculateRatio();
            }
        }

        class Window : DrawingObject
        {
            public Window(int x, int y, int z)
            {
                Matrix = new int[,]
                    {
                        { x,        y,      z,   1},
                        { x + 2,    y,      z,   1},
                        { x + 2,    y,      z,   1},
                        { x + 2,    y - 4,  z,   1},
                        { x + 2,    y - 4,  z,   1},
                        { x,        y - 4,  z,   1},
                        { x,        y - 4,  z,   1},
                        { x,        y,      z,   1},
                    };
            }
        }

        class Tower : DrawingObject
        {
            /// <summary>
            /// Содержит все отрисовываемые объекты-грани
            /// </summary>
            DrawingObject[] drawingObjects;
            public Tower(int x, int y, int z)
            {
                DrawingObject side1 = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 0, -14,     0,   1},   // Первая сторона
                    { 0,  10,     0,   1},
                    { 0,  10,     0,   1},
                    { 2,  10,     0,   1},
                    { 2,  10,     0,   1},
                    { 2,   8,     0,   1},
                    { 2,   8,     0,   1},
                    { 6,   8,     0,   1},
                    { 6,   8,     0,   1},
                    { 6,  10,     0,   1},
                    { 6,  10,     0,   1},
                    { 8,  10,     0,   1},
                    { 8,  10,     0,   1},
                    { 8, -14,     0,   1},
                    { 8, -14,     0,   1},
                    { 0, -14,     0,   1},
                    }
                };

                DrawingObject side2 = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 0, -14,     0,   1},  // Вторая сторона
                    { 0, -14,     8,   1},
                    { 0, -14,     8,   1},
                    { 0,  10,     8,   1},
                    { 0,  10,     8,   1},
                    { 0,  10,     6,   1},
                    { 0,  10,     6,   1},
                    { 0,   8,     6,   1},
                    { 0,   8,     6,   1},
                    { 0,   8,     2,   1},
                    { 0,   8,     2,   1},
                    { 0,  10,     2,   1},
                    { 0,  10,     2,   1},
                    { 0,  10,     0,   1},
                    }
                };

                DrawingObject side3 = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 8, -14,     0,   1},   // Третья сторона
                    { 8, -14,     8,   1},
                    { 8, -14,     8,   1},
                    { 8,  10,     8,   1},
                    { 8,  10,     8,   1},
                    { 8,  10,     6,   1},
                    { 8,  10,     6,   1},
                    { 8,   8,     6,   1},
                    { 8,   8,     6,   1},
                    { 8,   8,     2,   1},
                    { 8,   8,     2,   1},
                    { 8,  10,     2,   1},
                    { 8,  10,     2,   1},
                    { 8,  10,     0,   1},
                    }
                };

                DrawingObject side4 = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 8, -14,     8,   1},   // Четвертая сторона
                    { 0, -14,     8,   1},   
                    { 6,  10,     8,   1},
                    { 6,   8,     8,   1},
                    { 8,  10,     8,   1},
                    { 6,  10,     8,   1},
                    { 6,   8,     8,   1},
                    { 2,   8,     8,   1},
                    { 2,   8,     8,   1},
                    { 2,  10,     8,   1},
                    { 2,  10,     8,   1},
                    { 0,  10,     8,   1},
                    }
                };

                DrawingObject side5a = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 2,  10,     2,   1},   // Блоки
                    { 0,  10,     2,   1},
                    { 2,  10,     2,   1},
                    { 2,  10,     0,   1},
                    }
                };
                DrawingObject side5b = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 2,  10,     2,   1},
                    { 2,  10,     0,   1},
                    { 2,  10,     2,   1},
                    { 2,   8,     2,   1},
                    }
                };
                DrawingObject side5c = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 2,   8,     2,   1},
                    { 2,   8,     0,   1},
                    { 2,   8,     2,   1},
                    { 0,   8,     2,   1},
                    }
                };

                DrawingObject side6a = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 2,  10,     6,   1},   // Блоки
                    { 0,  10,     6,   1},
                    { 2,  10,     6,   1},
                    { 2,  10,     8,   1},
                    }
                };
                DrawingObject side6b = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 2,  10,     6,   1},
                    { 2,  10,     8,   1},
                    { 2,  10,     6,   1},
                    { 2,   8,     6,   1},
                    }
                };
                DrawingObject side6c = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 2,   8,     6,   1},
                    { 2,   8,     8,   1},
                    { 2,   8,     6,   1},
                    { 0,   8,     6,   1},
                    }
                };

                DrawingObject side7a = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 6,  10,     6,   1},   // Блоки
                    { 8,  10,     6,   1},
                    { 6,  10,     6,   1},
                    { 6,  10,     8,   1},
                    }
                };
                DrawingObject side7b = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 6,  10,     6,   1},
                    { 6,  10,     8,   1},
                    { 6,  10,     6,   1},
                    { 6,   8,     6,   1},
                    }
                };
                DrawingObject side7c = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 6,   8,     6,   1},
                    { 6,   8,     8,   1},
                    { 6,   8,     6,   1},
                    { 8,   8,     6,   1},
                    }
                };

                DrawingObject side8a = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 6,  10,     2,   1},   // Блоки
                    { 8,  10,     2,   1},
                    { 6,  10,     2,   1},
                    { 6,  10,     0,   1},
                    }
                };
                DrawingObject side8b = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 6,  10,     2,   1},
                    { 6,  10,     0,   1},
                    { 6,  10,     2,   1},
                    { 6,   8,     2,   1},
                    }
                };
                DrawingObject side8c = new DrawingObject()
                {
                    Matrix = new int[,]{
                    { 6,   8,     2,   1},
                    { 8,   8,     2,   1},
                    { 6,   8,     2,   1},
                    { 6,   8,     0,   1},
                    }
                };
                drawingObjects = new DrawingObject[]
                {
                    side1,
                    side2,
                    side3,
                    side4,
                    side5a,
                    side6a,
                    side7a,
                    side8a,
                    side5b,
                    side6b,
                    side7b,
                    side8b,
                    side5c,
                    side6c,
                    side7c,
                    side8c,
                };
                foreach (var item in drawingObjects)
                {
                    int length = item.Matrix.GetLength(0);
                    for (int i = 0; i < length; i++)
                    {
                        item.Matrix[i, 0] += x;
                        item.Matrix[i, 1] += y;
                        item.Matrix[i, 2] += z;
                    }
                }
            }

            public override void CalculateRatio()
            {
                foreach (var item in drawingObjects)
                {
                    item.CalculateRatio();
                }
            }

            public override void Draw(Graphics graphics, double[,] T)
            {
                foreach (var item in drawingObjects)
                {
                    item.Draw(graphics, T);
                }
            }
        }
        

        private class DrawingObject
        {
            /// <summary>
            /// Коэффециент уравнения плоскости
            /// </summary>
            private int A, B, C, D;

            /// <summary>
            /// Матрица точек
            /// </summary>
            public int[,] Matrix { get; set; }



            /// <summary>
            /// Отрисовка объекта
            /// </summary>
            /// <param name="graphics">Рисующий объект</param>
            /// <param name="T">Матрица обработки</param>
            public virtual void Draw(Graphics graphics, double[,] T)
            {
                int dx = (int)(graphics.ClipBounds.Width / 60); // Соотношение усл.ед к пикселям
                int dy = (int)(graphics.ClipBounds.Height / 60);
                dx = dy = Math.Min(dx, dy);
                int countRows = Matrix.GetLength(0);        //Количество строк
                double[,] matrixDrow = Multiply(Matrix, T); // Матрица отображения
                for (int i = 0; i < countRows; i++)         // Преобразование от усл. ед. к пикселям
                {
                    matrixDrow[i, 0] = (graphics.ClipBounds.Width / 2 + dx * matrixDrow[i, 0]);
                    matrixDrow[i, 1] = (graphics.ClipBounds.Height / 2 - dy * matrixDrow[i, 1]);
                }
                DrawLines(graphics, matrixDrow);     // Рисование
            }

            /// <summary>
            /// Рисует нужный тип объекта
            /// </summary>
            /// <param name="graphics">Рисующий объект</param>
            /// <param name="matrixDrow">Матрица отображения</param>
            private void DrawLines(Graphics graphics, double[,] matrixDrow)
            {
                int countRows = Matrix.GetLength(0);        //Количество строк
                for (int i = 1; i < countRows; i += 2)      // Рисование
                {
                    graphics.DrawLine(
                        Pens.Black,
                        (float)matrixDrow[i - 1, 0],
                        (float)matrixDrow[i - 1, 1],
                        (float)matrixDrow[i, 0],
                        (float)matrixDrow[i, 1] 
                    );
                }
            }

            /// <summary>
            /// Вычисление коэффециентов уравнения прямой
            /// </summary>
            public virtual void CalculateRatio()
            {
                A = 0;
                B = 0;
                C = 0;
                int j;
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    j = i == Matrix.GetUpperBound(0) ? 0 : i + 1;
                    A += (Matrix[i, 1] - Matrix[j, 1]) * (Matrix[i, 2] + Matrix[j, 2]);
                    B += (Matrix[i, 2] - Matrix[j, 2]) * (Matrix[i, 0] + Matrix[j, 0]);
                    C += (Matrix[i, 0] - Matrix[j, 0]) * (Matrix[i, 1] + Matrix[j, 1]);
                }
                D = -(A * Matrix[0, 0] + B * Matrix[0, 1] + C * Matrix[0, 2]);
            }
        }

        /// <summary>
        /// Перемножение матриц
        /// </summary>
        public static double[,] Multiply(int[,] m1, double[,] m2) 
        {
            double[,] result = new double[m1.GetLength(0), m2.GetLength(1)];

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    double sum = 0;

                    for (int k = 0; k < m1.GetLength(1); k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }

                    result[i, j] = sum;
                }
            }
            return result;
        }
        /// <summary>
        /// Перемножение матриц
        /// </summary>
        public static double[,] Multiply(double[,] m1, double[,] m2)
        {
            double[,] result = new double[m1.GetLength(0), m2.GetLength(1)];

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    double sum = 0;

                    for (int k = 0; k < m1.GetLength(1); k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }

                    result[i, j] = sum;
                }
            }
            return result;
        }

    }


}
