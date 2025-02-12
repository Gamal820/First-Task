using System; 

namespace firstappcsharp 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // طلب إدخال رقم من المستخدم
            Console.WriteLine("Enter Number :");
            // قراءة الرقم المدخل من المستخدم وتحويله إلى عدد صحيح
            int n = int.Parse(Console.ReadLine());

            // التحقق مما إذا كان الرقم زوجيًا
            if (n % 2 == 0)
            {
                // إذا كان الرقم زوجيًا، طباعة النتيجة
                Console.WriteLine($"{n} : is Even");
            }
            else
            {
                // إذا لم يكن الرقم زوجيًا، طباعة النتيجة
                Console.WriteLine($"{n} : is Odd");
            }
        }
    }
}
