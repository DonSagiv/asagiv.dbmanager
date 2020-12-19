func @_asagiv.dbmanager.webinterface.Startup.ConfigureServices$Microsoft.Extensions.DependencyInjection.IServiceCollection$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :26 :8) {
^entry (%_services : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :26 :38)
cbde.store %_services, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :26 :38)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :28 :12) // Not a variable of known type: services
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :28 :12) // services.AddRazorPages() (InvocationExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :29 :12) // Not a variable of known type: services
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :29 :12) // services.AddServerSideBlazor() (InvocationExpression)
%5 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :30 :12) // Not a variable of known type: services
%6 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :30 :12) // services.AddScoped<MainDbContextService>() (InvocationExpression)
%7 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :31 :12) // Not a variable of known type: services
%8 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :31 :12) // services.AddBlazorFileSaver() (InvocationExpression)
%9 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :32 :12) // Not a variable of known type: services
%10 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :32 :12) // services.AddBlazoredModal() (InvocationExpression)
%11 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :33 :12) // Not a variable of known type: services
%12 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :33 :12) // services.AddBlazorise() (InvocationExpression)
%13 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :34 :12) // Not a variable of known type: services
%14 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :34 :12) // services.AddBootstrapProviders() (InvocationExpression)
%15 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :35 :12) // Not a variable of known type: services
%16 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Startup.cs" :35 :12) // services.AddFontAwesomeIcons() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function Configure(none, none), it contains poisonous unsupported syntaxes

