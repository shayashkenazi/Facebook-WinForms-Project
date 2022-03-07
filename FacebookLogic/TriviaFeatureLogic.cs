using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class TriviaFeatureLogic
    {
        private static readonly List<string> sr_Q1OptionalAnswers = new List<string>()
        {
            "maccabi@walla.com", "djmabruk@gmail.com", "plumber@hotmail.com",
            "number1garage@yahoo.com", "bislihbamba@gmail.com"
        };

        private static readonly List<string> sr_Q2OptionalAnswers = new List<string>()
        {
            "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius",
            "Capricorn", "Aquarius", "Pisces"
        };

        private static readonly List<string> sr_Q3OptionalAnswers = new List<string>()
        {
            "Miami", "Los Angeles", "Jerusalem", "Rishon LeZion",
            "Tel Aviv", "Kefar Kasem", "Petah Tikva"
        };

        private static readonly List<string> sr_Q4OptionalAnswers = new List<string>()
        {
            "18", "65", "25", "53", "30", "20", "12"
        };

        private readonly Random r_Random = new Random();
        private User m_RandomFriend;
        
        public List<string> GetQuestionAnswers(List<string> i_AnswersBank, string i_RightAnswer)
        {
            List<string> answers = null;

            if (i_RightAnswer != null)
            {
                answers = new List<string>();

                answers.Add(i_RightAnswer);
                for (int i = 0; i < 3; ++i)
                {
                    int index = r_Random.Next(0, i_AnswersBank.Count);
                    if (i_RightAnswer != i_AnswersBank[index])
                    {
                        answers.Add(i_AnswersBank[index]);
                    }
                    else
                    {
                        i--;
                    }

                    i_AnswersBank.RemoveAt(index);
                }
            }

            Shuffle<string>(answers);

            return answers;
        }

        private void Shuffle<T>(IList<T> io_List)
        {
            if (io_List != null)
            {
                int len = io_List.Count;

                while (len > 1)
                {
                    len--;
                    int randomIndex = r_Random.Next(len + 1);
                    T value = io_List[randomIndex];
                    io_List[randomIndex] = io_List[len];
                    io_List[len] = value;
                }
            }
        }

        public User GetRandomFriend(List<User> i_Friends)
        {
            if (i_Friends.Count != 0)
            {
                m_RandomFriend = i_Friends[r_Random.Next(0, i_Friends.Count)];
            }
            else
            {
                m_RandomFriend = null;
            }

            return m_RandomFriend;
        }

        public List<string> GetQ1Answers()
        {
            return GetQuestionAnswers(new List<string>(sr_Q1OptionalAnswers), m_RandomFriend.Email);
        }

        public List<string> GetQ4Answers()
        {
            int ageOfFriend = GetAgeOfFriend(m_RandomFriend.Birthday);
            return GetQuestionAnswers(new List<string>(sr_Q4OptionalAnswers), ageOfFriend.ToString());
        }

        public List<string> GetQ3Answers()
        {
            return GetQuestionAnswers(new List<string>(sr_Q3OptionalAnswers), m_RandomFriend.Location.Name);
        }

        public List<string> GetQ2Answers()
        {
            string zodiacSign = AnalyzeZodiacSign(m_RandomFriend.Birthday);
            return GetQuestionAnswers(new List<string>(sr_Q2OptionalAnswers), zodiacSign);
        }

        public int GetAgeOfFriend(string i_Birthday)
        {
            return DateTime.Now.Year - DateTime.Parse(i_Birthday, new System.Globalization.CultureInfo("en-US")).Year;
        }

        public string AnalyzeZodiacSign(string i_Birthday)
        {
            string sign = null;

            if (i_Birthday != null)
            {
                DateTime birthday = DateTime.Parse(i_Birthday, new System.Globalization.CultureInfo("en-US"));
                if ((birthday.Month == 1 && birthday.Day >= 20) || (birthday.Month == 2 && birthday.Day <= 18))
                {
                    sign = "Aquarius";
                }
                else if ((birthday.Month == 2 && birthday.Day >= 19) || (birthday.Month == 3 && birthday.Day <= 20))
                {
                    sign = "Pisces";
                }
                else if ((birthday.Month == 3 && birthday.Day >= 21) || (birthday.Month == 4 && birthday.Day <= 19))
                {
                    sign = "Aries";
                }
                else if ((birthday.Month == 4 && birthday.Day >= 20) || (birthday.Month == 5 && birthday.Day <= 20))
                {
                    sign = "Taurus";
                }
                else if ((birthday.Month == 5 && birthday.Day >= 21) || (birthday.Month == 6 && birthday.Day <= 20))
                {
                    sign = "Gemini";
                }
                else if ((birthday.Month == 6 && birthday.Day >= 21) || (birthday.Month == 7 && birthday.Day <= 22))
                {
                    sign = "Cancer";
                }
                else if ((birthday.Month == 7 && birthday.Day >= 23) || (birthday.Month == 8 && birthday.Day <= 22))
                {
                    sign = "Leo";
                }
                else if ((birthday.Month == 8 && birthday.Day >= 23) || (birthday.Month == 9 && birthday.Day <= 22))
                {
                    sign = "Virgo";
                }
                else if ((birthday.Month == 9 && birthday.Day >= 23) || (birthday.Month == 10 && birthday.Day <= 22))
                {
                    sign = "Libra";
                }
                else if ((birthday.Month == 10 && birthday.Day >= 23) || (birthday.Month == 11 && birthday.Day <= 22))
                {
                    sign = "Scorpio";
                }
                else if ((birthday.Month == 11 && birthday.Day >= 23) || (birthday.Month == 12 && birthday.Day <= 21))
                {
                    sign = "Sagittarius";
                }
                else if ((birthday.Month == 12 && birthday.Day >= 22) || (birthday.Month == 1 && birthday.Day <= 19))
                {
                    sign = "Capricon";
                }
            }

            return sign;
        }

        public int AnalyzeAnswers(string i_EmailAnswer, string i_ZodiaCSignAnswer, string i_LocationAnswer, string i_AgeOfFriend)
        {
            int rightAnswersCounter = 0;
            if (m_RandomFriend.Email != null && m_RandomFriend.Email.Equals(i_EmailAnswer))
            {
                ++rightAnswersCounter;
            }

            if (m_RandomFriend.Birthday != null && AnalyzeZodiacSign(m_RandomFriend.Birthday).Equals(i_ZodiaCSignAnswer))
            {
                ++rightAnswersCounter;
            }

            if (m_RandomFriend.Location != null && m_RandomFriend.Location.Name.Equals(i_LocationAnswer))
            {
                ++rightAnswersCounter;
            }

            if (m_RandomFriend.Birthday != null && GetAgeOfFriend(m_RandomFriend.Birthday) == int.Parse(i_AgeOfFriend))
            {
                ++rightAnswersCounter;
            }

            return rightAnswersCounter;
        }
    }
}
