namespace Code
{
    public class Scanner
    {
        public int Scan(string item)
        {
            switch (item)
            {
                case "A":
                    return 50;
                case "B":
                    return 30;
                case "C":
                    return 20;
                case "D":
                    return 15;
                default:
                    return 0;
            }
        }
    }
}
