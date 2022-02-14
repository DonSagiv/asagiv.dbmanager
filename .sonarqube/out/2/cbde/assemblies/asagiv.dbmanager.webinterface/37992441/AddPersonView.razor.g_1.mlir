// Skipping function BuildRenderTree(none), it contains poisonous unsupported syntaxes

// Skipping function OnInitializedAsync(), it contains poisonous unsupported syntaxes

func @_asagiv.dbmanager.webinterface.Pages.AddPersonView.addNewMember$$() -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :875 :4) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :877 :8) // Not a variable of known type: family
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :877 :8) // family.familyMembers (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :877 :33) // new Person() (ObjectCreationExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :877 :8) // family.familyMembers.Add(new Person()) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_asagiv.dbmanager.webinterface.Pages.AddPersonView.addNewAddress$$() -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :880 :4) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :882 :8) // Not a variable of known type: family
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :882 :8) // family.addresses (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :882 :29) // new Address() (ObjectCreationExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :882 :8) // family.addresses.Add(new Address()) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_asagiv.dbmanager.webinterface.Pages.AddPersonView.deleteMember$asagiv.dbmanager.addresses.Person$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :885 :4) {
^entry (%_member : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :885 :29)
cbde.store %_member, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :885 :29)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :887 :8) // Not a variable of known type: family
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :887 :8) // family.familyMembers (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :887 :36) // Not a variable of known type: member
%4 = cbde.unknown : i1 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :887 :8) // family.familyMembers.Remove(member) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_asagiv.dbmanager.webinterface.Pages.AddPersonView.deleteAddress$asagiv.dbmanager.addresses.Address$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :890 :4) {
^entry (%_addressToRemove : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :890 :30)
cbde.store %_addressToRemove, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :890 :30)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :892 :8) // Not a variable of known type: family
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :892 :8) // family.addresses (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :892 :32) // Not a variable of known type: addressToRemove
%4 = cbde.unknown : i1 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :892 :8) // family.addresses.Remove(addressToRemove) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function onAddNewPersonClickAsync(), it contains poisonous unsupported syntaxes

func @___Blazor.asagiv.dbmanager.webinterface.Pages.AddPersonView.TypeInference.CreateDateEdit_0$TValue$$Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.int.int.TValue.int.Microsoft.AspNetCore.Components.EventCallback$TValue$.int.System.Linq.Expressions.Expression$System.Func$TValue$$$(none, i32, i32, none, i32, none, i32, none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :8) {
^entry (%___builder : none, %_seq : i32, %___seq0 : i32, %___arg0 : none, %___seq1 : i32, %___arg1 : none, %___seq2 : i32, %___arg2 : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :52)
cbde.store %___builder, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :52)
%1 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :131)
cbde.store %_seq, %1 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :131)
%2 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :140)
cbde.store %___seq0, %2 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :140)
%3 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :152)
cbde.store %___arg0, %3 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :152)
%4 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :167)
cbde.store %___seq1, %4 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :167)
%5 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :179)
cbde.store %___arg1, %5 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :179)
%6 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :249)
cbde.store %___seq2, %6 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :249)
%7 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :261)
cbde.store %___arg2, %7 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :913 :261)
br ^0

^0: // SimpleBlock
%8 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :915 :8) // Not a variable of known type: __builder
%9 = cbde.load %1 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :915 :68)
%10 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :915 :8) // __builder.OpenComponent<global::Blazorise.DateEdit<TValue>>(seq) (InvocationExpression)
%11 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :916 :8) // Not a variable of known type: __builder
%12 = cbde.load %2 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :916 :31)
%13 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :916 :39) // "Date" (StringLiteralExpression)
%14 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :916 :47) // Not a variable of known type: __arg0
%15 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :916 :8) // __builder.AddAttribute(__seq0, "Date", __arg0) (InvocationExpression)
%16 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :917 :8) // Not a variable of known type: __builder
%17 = cbde.load %4 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :917 :31)
%18 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :917 :39) // "DateChanged" (StringLiteralExpression)
%19 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :917 :54) // Not a variable of known type: __arg1
%20 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :917 :8) // __builder.AddAttribute(__seq1, "DateChanged", __arg1) (InvocationExpression)
%21 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :918 :8) // Not a variable of known type: __builder
%22 = cbde.load %6 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :918 :31)
%23 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :918 :39) // "DateExpression" (StringLiteralExpression)
%24 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :918 :57) // Not a variable of known type: __arg2
%25 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :918 :8) // __builder.AddAttribute(__seq2, "DateExpression", __arg2) (InvocationExpression)
%26 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :919 :8) // Not a variable of known type: __builder
%27 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddPersonView.razor.g.cs" :919 :8) // __builder.CloseComponent() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
