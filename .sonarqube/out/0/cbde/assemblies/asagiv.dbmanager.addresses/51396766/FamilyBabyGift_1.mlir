func @_asagiv.dbmanager.addresses.FamilyBabyGift.ToString$$() -> none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :45 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :47 :22) // Not a variable of known type: family
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :47 :22) // family.ToSearchableString() (InvocationExpression)
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :47 :52) // Not a variable of known type: babyGift
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :47 :52) // babyGift.giftDescription (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :47 :19) // $"{family.ToSearchableString()} {babyGift.giftDescription}" (InterpolatedStringExpression)
return %4 : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :47 :12)

^1: // ExitBlock
cbde.unreachable

}
