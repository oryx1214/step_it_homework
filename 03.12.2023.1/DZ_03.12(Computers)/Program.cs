
using hw.PC.Classes;

var officeBuilder = new OfficePcBuilder();
var gamingBuilder = new GamingPcBuilder();
var designerBuilder = new DesignerPcBuilder();

var director = new PcDirector();

director.ConstructPc(gamingBuilder);
var gamingPC = gamingBuilder.GetPc();
Console.WriteLine("Gaming Pc setup: ");
gamingPC.DisplayInformation();
Console.WriteLine();

director.ConstructPc(officeBuilder);

var officePC = officeBuilder.GetPc();
Console.WriteLine("Office Pc setup: ");
officePC.DisplayInformation();
Console.WriteLine();

director.ConstructPc(designerBuilder);

var designerPC = designerBuilder.GetPc();
Console.WriteLine("Designer Pc setup: ");
designerPC.DisplayInformation();