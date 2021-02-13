namespace Challenge
{
    public class Point
    {
        public Point(int x, int y, string orientation)
        {
            X = x;
            Y = y;
            Orientation = orientation;
        }

        public int X { get; set; } = 0;

        public int Y { get; set; } = 0;

        public string Orientation { get; set; } = "Norte";

        public void Turn(char dir)
        {
            switch (Orientation)
            {
                case "Norte":
                    {
                        if (dir == 'I')
                            Orientation = "Occidente";
                        else
                            Orientation = "Oriente";
                    }
                    break;
                case "Sur":
                    {
                        if (dir == 'I')
                            Orientation = "Oriente";
                        else
                            Orientation = "Occidente";
                    }
                    break;
                case "Oriente":
                    {
                        if (dir == 'I')
                            Orientation = "Norte";
                        else
                            Orientation = "Sur";
                    }
                    break;
                case "Occidente":
                    {
                        if (dir == 'I')
                            Orientation = "Sur";
                        else
                            Orientation = "Norte";
                    }
                    break;
            }
        }

        public void Move()
        {
            switch (Orientation)
            {
                case "Norte":
                    {
                        Y += 1;
                    }
                    break;
                case "Sur":
                    {
                        Y -= 1;
                    }
                    break;
                case "Oriente":
                    {
                        X += 1;
                    }
                    break;
                case "Occidente":
                    {
                        X -= 1;
                    }
                    break;
            }
        }

        public void Go(string route)
        {
            for (int x = 0; x < route.Length; x++)
            {
                char i = route[x];
                if (i == 'A')
                    Move();
                else Turn(i);
            }
        }

        public Point Clone()
        {
            return new Point(X, Y, Orientation);
        }
    }
}
