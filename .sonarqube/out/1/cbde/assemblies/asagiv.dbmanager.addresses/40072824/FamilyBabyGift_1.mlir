func @_asagiv.dbmanager.addresses.FamilyBabyGift.ToString$$() -> none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :46 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :48 :22) // Not a variable of known type: family
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :48 :22) // family.ToSearchableString() (InvocationExpression)
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :48 :52) // Not a variable of known type: babyGift
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :48 :52) // babyGift.giftDescription (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :48 :19) // $"{family.ToSearchableString()} {babyGift.giftDescription}" (InterpolatedStringExpression)
return %4 : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\FamilyBabyGift.cs" :48 :12)

^1: // ExitBlock
cbde.unreachable

}
