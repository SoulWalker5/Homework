using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    class AddPeople : Menu
    {
        private Auditoriya auditoriya;

        public AddPeople(Auditoriya auditoriya)
        {
            this.auditoriya = auditoriya;
        }

        protected override void InternalLogic()
        {
            Random random = new Random();
            var key = random.Next(2);

            Human human = null;

            if (key == 0)
                human = new Teatcher();
            if (key == 1)
                human = new Student();

            auditoriya.AddPeople(human);
            auditoriya.PrintInfo();

        }
    }
}
