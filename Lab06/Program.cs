git config --global user.email "Kaorawith.khla@bu.ac.th"
git config --global user.name "Kaorawith Khlaharn"
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 1; // ตัวแปรหลักเพื่อเซ็ต
            if (lives <= 0) // ในวงเล็บคือเงื่อนไขที่จะต้องเป็นจริง
            {
                // บล็อคของโค้ดที่จำทำงานเมื่อเงื่อนไขเป็นจริง
                Console.WriteLine("You are dead");
            }
            else
            {
                Console.WriteLine("You are alive");
            }

            // เมื่อเงื่อนไขทำงานเสร็จแล้ว หรือ เงื่อนไขไม่ตรงเลบโค๊ดทำงานต่อ
            Console.WriteLine("continue to run");

            bool isPoisioned = false;
            if (isPoisioned) { }
            if (!isPoisioned) { }

            Console.WriteLine("your level (1-99)");
            bool ok = int.TryParse(Console.ReadLine(), out int level);

            if (!ok || level < 1 ||  level > 99)
            {
                Console.WriteLine("Invalid level Input");
            }
            if (level >= 10)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                Console.WriteLine("The door opens.");
            }
            else
            {
                Console.WriteLine("The door stay shut.");
            }
        }
    }
}
