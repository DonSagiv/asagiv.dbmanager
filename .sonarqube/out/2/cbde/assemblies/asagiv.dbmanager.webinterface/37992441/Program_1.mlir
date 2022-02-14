func @_asagiv.dbmanager.webinterface.Program.Main$string$$$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Program.cs" :8 :8) {
^entry (%_args : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Program.cs" :8 :32)
cbde.store %_args, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Program.cs" :8 :32)
br ^0

^0: // SimpleBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: CreateHostBuilder
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Program.cs" :10 :30) // Not a variable of known type: args
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Program.cs" :10 :12) // CreateHostBuilder(args) (InvocationExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Program.cs" :10 :12) // CreateHostBuilder(args).Build() (InvocationExpression)
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\Program.cs" :10 :12) // CreateHostBuilder(args).Build().Run() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
