using FacadePattern.Multiple;
using FacadePattern.Nested;
using FacadePattern.Single;

SingleFacade singleFacade = new SingleFacade();
singleFacade.ConvertImageFileToText("sample.png");

MultipleFacade multipleFacade = new MultipleFacade();
multipleFacade.ConvertImageFileToText("sample.png");

NestedFacade nestedFacade = new NestedFacade();
nestedFacade.ConvertImageFileToText("sample.png");

Console.WriteLine("Done!");
Console.ReadLine();
