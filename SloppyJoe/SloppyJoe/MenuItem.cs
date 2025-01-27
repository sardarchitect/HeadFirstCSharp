namespace SloppyJoe
{
    internal class MenuItem
    {
        public string[] Proteins = [
            "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"
            ];
        public string[] Condiments = [
            "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "French dressing"
            ];

        public string[] Breads = ["rye", "white", "wheat", "pumpernickel", "a roll"];

        public string Description = "";
        public string Price = "";

        public void Generate()
        {
            string protein = Proteins[Random.Shared.Next(0, Proteins.Length)];
            string condiment = Condiments[Random.Shared.Next(0, Condiments.Length)];
            string bread = Breads[Random.Shared.Next(0, Breads.Length)];

            Description = protein + " with " + condiment + " on " + bread;
            Price = (Random.Shared.NextDouble() * 10 + 5).ToString("c");
        }
    }
}