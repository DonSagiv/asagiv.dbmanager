func @_asagiv.dbmanager.addresses.Family.ToString$$() -> none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :49 :8) {
^entry :
br ^0

^0: // JumpBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: ToAddressString
%0 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :51 :19) // ToAddressString() (InvocationExpression)
return %0 : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :51 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function ToSearchableString(), it contains poisonous unsupported syntaxes

func @_asagiv.dbmanager.addresses.Family.ToAddressString$$() -> none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :61 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :63 :21) // new StringBuilder() (ObjectCreationExpression)
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :65 :33) // Not a variable of known type: addresses
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :65 :33) // addresses.FirstOrDefault() (InvocationExpression)
%5 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :67 :12) // Not a variable of known type: sb
%6 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :67 :26) // Not a variable of known type: addressHeader
%7 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :67 :12) // sb.AppendLine(addressHeader) (InvocationExpression)
%8 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :68 :12) // Not a variable of known type: sb
%9 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :68 :26) // Not a variable of known type: primaryAddress
%10 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :68 :26) // primaryAddress.ToString() (InvocationExpression)
%11 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :68 :12) // sb.AppendLine(primaryAddress.ToString()) (InvocationExpression)
%12 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :70 :19) // Not a variable of known type: sb
%13 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :70 :19) // sb.ToString() (InvocationExpression)
return %13 : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Family.cs" :70 :12)

^1: // ExitBlock
cbde.unreachable

}
