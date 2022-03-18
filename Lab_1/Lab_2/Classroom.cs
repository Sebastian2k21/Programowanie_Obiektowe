namespace Lab_2
{
    class Classroom
    {
        private string name;

        private Person[] persons;

        public string Name { get => name; set => name = value; }

        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string results = $"Classroom: {name}\n";

            for (int i = 0; i < persons.Length; i++)
            {
                results += $"{persons[i]}\n";
            }

            return results;
        }
    }
}
