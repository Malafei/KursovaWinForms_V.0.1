using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaWinForms_V._0._1
{
    [Serializable]
    public class User
    {
        public string Logining { get; set; }
        public string Passwording { get; set; }

        public List<string> BaseSentence { get; set; }
        public List<Statistic> Statistic { get; set; }
        public User(string password, string login)
        {
            Statistic = new List<Statistic>();
            Logining = login;
            Passwording = password;
            BaseSentence = new List<string>();
            string tmp = "Hello! My name is Kate. My surname is Pavlova. " +
                         "I’m seven. I live in Minsk, in Pushkin street. " +
                         "I go to school number 214.I’m in the first form. " +
                         "I’ve got a family. It is small.We are a family of four. " +
                         "I’ve got a father, a mother and a brother. " +
                         "I haven’t got a sister. My father is.an engineer." +
                         "He works in a plant. My mother is a teacher. " +
                         "She works at school. My brother is little.He doesn’t" +
                         "go to school. He goes to a kindergarten.He is four." +
                         "I like to play. I have got many toys.I have got a" +
                         "teddy - bear, dolls, a ball, a toy monkey and a doll’s house." +
                         "I like the doll’s house very much. It is big.It is pink and nice." +
                         "We have got a cat.It is small and grey.It is very nice. " +
                         "It has big blue eyes, a funny nose, a small mouth and sharp teeth. " +
                         "Its ears are small. It can play hide-and - seek.I love my cat.It loves me, too." +
                         "I go to school. I’m a pupil.I have got many friends.We have our classroom. " +
                         "It is nice and large.You can see twelve desks, many chairs, our teacher’s table, a blackboard," +
                         "two bookcases in the classroom. At the lessons we have pens, pencils, pencil-boxes or pencil-cases," +
                         "rulers, erasers, textbooks, exercise - books, record - books on the desks." +
                         "I like to read. I can read well. I like fairytales.They are very interesting." +
                         "I like «Cinderella» and «Pinocchio» best.Bye!";
            BaseSentence.Add(tmp);
        }

        public User()
        {
            BaseSentence = new List<string>();
            Statistic = new List<Statistic>();
            Logining = default;
            Passwording = default;
            string tmp = "Hello! My name is Kate. My surname is Pavlova. " +
                        "I’m seven. I live in Minsk, in Pushkin street. " +
                        "I go to school number 214.I’m in the first form. " +
                        "I’ve got a family. It is small.We are a family of four. " +
                        "I’ve got a father, a mother and a brother. " +
                        "I haven’t got a sister. My father is.an engineer." +
                        "He works in a plant. My mother is a teacher. " +
                        "She works at school. My brother is little.He doesn’t" +
                        "go to school. He goes to a kindergarten.He is four." +
                        "I like to play. I have got many toys.I have got a" +
                        "teddy - bear, dolls, a ball, a toy monkey and a doll’s house." +
                        "I like the doll’s house very much. It is big.It is pink and nice." +
                        "We have got a cat.It is small and grey.It is very nice. " +
                        "It has big blue eyes, a funny nose, a small mouth and sharp teeth. " +
                        "Its ears are small. It can play hide-and - seek.I love my cat.It loves me, too." +
                        "I go to school. I’m a pupil.I have got many friends.We have our classroom. " +
                        "It is nice and large.You can see twelve desks, many chairs, our teacher’s table, a blackboard," +
                        "two bookcases in the classroom. At the lessons we have pens, pencils, pencil-boxes or pencil-cases," +
                        "rulers, erasers, textbooks, exercise - books, record - books on the desks." +
                        "I like to read. I can read well. I like fairytales.They are very interesting." +
                        "I like «Cinderella» and «Pinocchio» best.Bye!";
            BaseSentence.Add(tmp);
        }






    }
}
