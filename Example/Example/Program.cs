using System;

namespace example
{
    class studentInfo
    {

        private string id;
        private string name;
        private int marks;

        public string std_id
        {
            get { return id; }
            set { id = value; }
        }
        public string std_name
        {
            get { return name; }
            set { name = value; }
        }
        public int std_marks
        {
            get { return marks; }
            set { marks = value; }
        }

    }

    class stdinfo
    {
        static void Main()
        {
            studentInfo instance = new studentInfo();
            instance.std_id = "25";
            instance.std_name = "Ram";
            instance.std_marks = 85;

            Console.WriteLine(instance.std_id);
            Console.WriteLine(instance.std_name);
            Console.WriteLine(instance.std_marks);

        }
    }

}

