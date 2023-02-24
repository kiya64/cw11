namespace WebApplication3.TIME
{
    public static class shamsi
    {
        public static string prs(this DateTime time_x)
        {

            int d = 0;
            int m = 0;
            int y = 0;
            int[] mah;


            if ((time_x.Year % 4 == 0 && time_x.Year % 100 != 0) || time_x.Year % 400 == 0)
            {

                int[] h = { 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335 };
                mah = h;


            }
            else
            {
                int[] h = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
                mah = h;
            }
            int all_of_days = mah[(time_x.Month) - 1] + time_x.Day;
            if (all_of_days <= 79)
            {
                if (time_x.Year % 4 == 1)
                {
                    all_of_days += 11;

                }
                else
                {
                    all_of_days += 10;
                }
                switch (all_of_days % 30)
                {

                    case 0:
                        m = (all_of_days / 30) + 9;
                        d = 30;
                        break;
                    default:
                        m = (all_of_days / 30) + 10;
                        d = all_of_days % 30;
                        break;
                }
                y = time_x.Year - 622;
            }
            else
            {
                all_of_days -= 79;
                if (all_of_days <= 186)
                {
                    switch (all_of_days % 31)
                    {
                        case 0:
                            m = (all_of_days / 31);
                            d = 31;
                            break;
                        default:
                            m = (all_of_days / 31) + 1;
                            d = all_of_days % 31;
                            break;

                    }
                    y = time_x.Year - 621;
                }
                else
                {
                    all_of_days -= 186;
                    switch (all_of_days % 30)
                    {
                        case 0:
                            m = (all_of_days / 30) + 6;
                            d = 30;
                            break;
                        default:
                            m = (all_of_days / 30) + 7;
                            d = all_of_days % 30;
                            break;

                    }
                    y = time_x.Year - 621;
                }
            }
            string ti = Convert.ToString(y + "/" + m + "/" + d);

            return ti;
        }
    }
}

