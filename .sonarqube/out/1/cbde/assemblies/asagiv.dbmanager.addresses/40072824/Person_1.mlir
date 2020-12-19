func @_asagiv.dbmanager.addresses.Person.getAge$$() -> none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :45 :8) {
^entry :
br ^0

^0: // BinaryBranchBlock
%0 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :47 :16) // Not a variable of known type: dateOfBirth
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :47 :31) // null (NullLiteralExpression)
%2 = cbde.unknown : i1  loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :47 :16) // comparison of unknown type: dateOfBirth == null
cond_br %2, ^1, ^2 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :47 :16)

^1: // JumpBlock
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :48 :23) // null (NullLiteralExpression)
return %3 : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :48 :16)

^2: // JumpBlock
// Entity from another assembly: DateTime
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :50 :26) // DateTime.Now (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :50 :41) // Not a variable of known type: dateOfBirth
%6 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :50 :26) // Binary expression on unsupported types DateTime.Now - dateOfBirth
%8 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :20) // Not a variable of known type: zeroTime
%9 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :31) // Not a variable of known type: ageSpan
%10 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :31) // ageSpan.Value (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :20) // Binary expression on unsupported types zeroTime + ageSpan.Value
%12 = cbde.unknown : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :19) // (zeroTime + ageSpan.Value).Year (SimpleMemberAccessExpression)
%13 = constant 1 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :53)
%14 = subi %12, %13 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :19)
%15 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :19) // Dummy variable because type of %14 is incompatible
return %15 : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Person.cs" :51 :12)

^3: // ExitBlock
cbde.unreachable

}
// Skipping function ToString(), it contains poisonous unsupported syntaxes

