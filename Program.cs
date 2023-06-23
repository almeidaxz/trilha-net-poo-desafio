using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia = new Nokia("71987654321", "Tijolão", 1111111111111111, 64);
var iphone = new Iphone("71912345678", "Iphone 13", 2222222222222222, 128);

nokia.ReceberLigacao();
Thread.Sleep(500);

nokia.InstalarAplicativo("CrunchyRoll");
Thread.Sleep(500);

iphone.ReceberLigacao();
Thread.Sleep(500);

iphone.InstalarAplicativo("CrunchyRoll");
Thread.Sleep(500);
