using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia meuNokia = new Nokia("123456789", "Nokia 3310", "111222333444", 32);
        
        meuNokia.Ligar();
        meuNokia.InstalarAplicativo("WhatsApp"); 

        Iphone novoIphone = new Iphone("41992795999", "Iphone Xr", "1234567890", 128);

        novoIphone.Ligar();
        novoIphone.InstalarAplicativo("Clash Royale");
    }
}
