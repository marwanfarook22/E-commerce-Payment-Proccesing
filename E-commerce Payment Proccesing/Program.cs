



using E_commerce_Payment_Proccesing.Service;
using E_commerce_Payment_Proccesing.UserinterAction;
using E_commerce_Payment_Proccesing.Userinterface;

var R = new ProudectService();
var U = new ManualProudectsUserInterface();
var I = new proudectUserInteraction();
var ProudectList = R.ReadProudctJson();
U.DisplayProudects(ProudectList);

I.UserChossenProudect(ProudectList);
Console.ReadKey();