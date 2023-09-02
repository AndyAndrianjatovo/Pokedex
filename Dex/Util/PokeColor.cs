namespace Dex.Util
{
    public static class PokeColor
    {
        public static string GetTypeColor(string type)
        {
            string color = type switch
            {
                "bug" => "#26de81",//vert kely lime 300 bg-lime-50 text-lime-300 ring-1 ring-inset ring-lime-600/20
                "dragon" => "#ffeaa7",//jaune kely amber 300 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "electric" => "#fed330",//jaune yellow 400 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "fairy" => "#ec4899",//rose pink 500 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "fighting" => "#30336b",// violet be Indigo 950 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "fire" => "#f0932b", // orange orange 600 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "flying" => "#81ecec",// bleu kely sky 300 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "grass" => "#00b894", //vert be green 950 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "ground" => "#EFB549",//marron kely yellow 900 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "ghost" => "#a55eea",//violet normal be Fuchsia 950 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "ice" => "#74b9ff",//bleu normal blue 500 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "normal" => "#95afc0",//gris normal gray 500 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "poison" => "#6c5ce7", // violet normal violet 600 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "psychic" => "#a29bfe",// violet kely violet 400 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "rock" => "#422006",// gris be yellow 950 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "water" => "#0190FF",// bleu be blue 800 bg-yellow-50 text-yellow-800 ring-1 ring-inset ring-yellow-600/20
                "steel" => "",//gris kely gray 800
                _ => "#0190FF"
            };

            return color;
        }

        public static string GetStatColor(string stat)
        {
            string color = stat switch
            {
                "hp" => "#FE0000",
                "attack" => "#EE7F30",
                "defense" => "#F7D02C",
                "special-attack" => "#F85687",
                "special-defense" => "#77C755",
                "speed" => "#678FEE",
                _ => "#0190FF"
            };

            return color;
        }
    }
}
