



using E_commerce_Payment_Proccesing.Service;
using E_commerce_Payment_Proccesing.Userinterface;

var R = new ProudectService();
var U = new UserInterface();
var ProudectList = R.ReadProudctJson();
U.DisplayProudectsManual(ProudectList);
Console.ReadKey();