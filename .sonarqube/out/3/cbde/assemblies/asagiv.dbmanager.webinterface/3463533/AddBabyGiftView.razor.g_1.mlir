// Skipping function BuildRenderTree(none), it contains poisonous unsupported syntaxes

// Skipping function OnInitializedAsync(), it contains poisonous unsupported syntaxes

// Skipping function findFamiliesAsync(none), it contains poisonous unsupported syntaxes

func @_asagiv.dbmanager.webinterface.Pages.AddBabyGiftView.addNewBenefactor$Microsoft.AspNetCore.Components.Web.MouseEventArgs$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :442 :4) {
^entry (%_e : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :442 :33)
cbde.store %_e, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :442 :33)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :444 :8) // Not a variable of known type: selectedFamilies
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :444 :29) // new SelectedListItem<FamilyBabyGift>() (ObjectCreationExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :444 :8) // selectedFamilies.Add(new SelectedListItem<FamilyBabyGift>()) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function onNewGiftValidSubmitAsync(), it contains poisonous unsupported syntaxes

func @_asagiv.dbmanager.webinterface.Pages.AddBabyGiftView.removeBenefactor$asagiv.dbmanager.webinterface.Data.SelectedListItem$asagiv.dbmanager.addresses.FamilyBabyGift$$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :453 :4) {
^entry (%_familyBabyGift : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :453 :33)
cbde.store %_familyBabyGift, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :453 :33)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :455 :12) // Not a variable of known type: selectedFamilies
%2 = cbde.unknown : i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :455 :12) // selectedFamilies.Count (SimpleMemberAccessExpression)
%3 = constant 0 : i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :455 :37)
%4 = cmpi "sgt", %2, %3 : i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :455 :12)
cond_br %4, ^1, ^2 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :455 :12)

^1: // SimpleBlock
%5 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :456 :12) // Not a variable of known type: selectedFamilies
%6 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :456 :36) // Not a variable of known type: familyBabyGift
%7 = cbde.unknown : i1 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :456 :12) // selectedFamilies.Remove(familyBabyGift) (InvocationExpression)
br ^2

^2: // ExitBlock
return

}
func @___Blazor.asagiv.dbmanager.webinterface.Pages.AddBabyGiftView.TypeInference.CreateBlazoredTypeahead_0$TItem.TValue$$Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.int.int.System.Func$string.System.Threading.Tasks.Task$System.Collections.Generic.IEnumerable$TItem$$$.int.bool.int.bool.int.int.int.object.int.TValue.int.Microsoft.AspNetCore.Components.EventCallback$TValue$.int.System.Linq.Expressions.Expression$System.Func$TValue$$.int.Microsoft.AspNetCore.Components.RenderFragment$TValue$.int.Microsoft.AspNetCore.Components.RenderFragment$TItem$$(none, i32, i32, none, i32, i1, i32, i1, i32, i32, i32, none, i32, none, i32, none, i32, none, i32, none, i32, none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :8) {
^entry (%___builder : none, %_seq : i32, %___seq0 : i32, %___arg0 : none, %___seq1 : i32, %___arg1 : i1, %___seq2 : i32, %___arg2 : i1, %___seq3 : i32, %___arg3 : i32, %___seq4 : i32, %___arg4 : none, %___seq5 : i32, %___arg5 : none, %___seq6 : i32, %___arg6 : none, %___seq7 : i32, %___arg7 : none, %___seq8 : i32, %___arg8 : none, %___seq9 : i32, %___arg9 : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :68)
cbde.store %___builder, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :68)
%1 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :147)
cbde.store %_seq, %1 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :147)
%2 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :156)
cbde.store %___seq0, %2 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :156)
%3 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :168)
cbde.store %___arg0, %3 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :168)
%4 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :311)
cbde.store %___seq1, %4 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :311)
%5 = cbde.alloca i1 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :323)
cbde.store %___arg1, %5 : memref<i1> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :323)
%6 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :354)
cbde.store %___seq2, %6 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :354)
%7 = cbde.alloca i1 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :366)
cbde.store %___arg2, %7 : memref<i1> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :366)
%8 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :397)
cbde.store %___seq3, %8 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :397)
%9 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :409)
cbde.store %___arg3, %9 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :409)
%10 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :438)
cbde.store %___seq4, %10 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :438)
%11 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :450)
cbde.store %___arg4, %11 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :450)
%12 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :472)
cbde.store %___seq5, %12 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :472)
%13 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :484)
cbde.store %___arg5, %13 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :484)
%14 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :499)
cbde.store %___seq6, %14 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :499)
%15 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :511)
cbde.store %___arg6, %15 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :511)
%16 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :581)
cbde.store %___seq7, %16 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :581)
%17 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :593)
cbde.store %___arg7, %17 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :593)
%18 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :673)
cbde.store %___seq8, %18 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :673)
%19 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :685)
cbde.store %___arg8, %19 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :685)
%20 = cbde.alloca i32 loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :756)
cbde.store %___seq9, %20 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :756)
%21 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :768)
cbde.store %___arg9, %21 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :471 :768)
br ^0

^0: // SimpleBlock
%22 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :473 :8) // Not a variable of known type: __builder
%23 = cbde.load %1 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :473 :93)
%24 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :473 :8) // __builder.OpenComponent<global::Blazored.Typeahead.BlazoredTypeahead<TItem, TValue>>(seq) (InvocationExpression)
%25 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :474 :8) // Not a variable of known type: __builder
%26 = cbde.load %2 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :474 :31)
%27 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :474 :39) // "SearchMethod" (StringLiteralExpression)
%28 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :474 :55) // Not a variable of known type: __arg0
%29 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :474 :8) // __builder.AddAttribute(__seq0, "SearchMethod", __arg0) (InvocationExpression)
%30 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :475 :8) // Not a variable of known type: __builder
%31 = cbde.load %4 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :475 :31)
%32 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :475 :39) // "EnableDropDown" (StringLiteralExpression)
%33 = cbde.load %5 : memref<i1> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :475 :57)
%34 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :475 :8) // __builder.AddAttribute(__seq1, "EnableDropDown", __arg1) (InvocationExpression)
%35 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :476 :8) // Not a variable of known type: __builder
%36 = cbde.load %6 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :476 :31)
%37 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :476 :39) // "ShowDropDownOnFocus" (StringLiteralExpression)
%38 = cbde.load %7 : memref<i1> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :476 :62)
%39 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :476 :8) // __builder.AddAttribute(__seq2, "ShowDropDownOnFocus", __arg2) (InvocationExpression)
%40 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :477 :8) // Not a variable of known type: __builder
%41 = cbde.load %8 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :477 :31)
%42 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :477 :39) // "MaximumSuggestions" (StringLiteralExpression)
%43 = cbde.load %9 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :477 :61)
%44 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :477 :8) // __builder.AddAttribute(__seq3, "MaximumSuggestions", __arg3) (InvocationExpression)
%45 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :478 :8) // Not a variable of known type: __builder
%46 = cbde.load %10 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :478 :31)
%47 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :478 :39) // "placeHolder" (StringLiteralExpression)
%48 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :478 :54) // Not a variable of known type: __arg4
%49 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :478 :8) // __builder.AddAttribute(__seq4, "placeHolder", __arg4) (InvocationExpression)
%50 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :479 :8) // Not a variable of known type: __builder
%51 = cbde.load %12 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :479 :31)
%52 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :479 :39) // "Value" (StringLiteralExpression)
%53 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :479 :48) // Not a variable of known type: __arg5
%54 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :479 :8) // __builder.AddAttribute(__seq5, "Value", __arg5) (InvocationExpression)
%55 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :480 :8) // Not a variable of known type: __builder
%56 = cbde.load %14 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :480 :31)
%57 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :480 :39) // "ValueChanged" (StringLiteralExpression)
%58 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :480 :55) // Not a variable of known type: __arg6
%59 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :480 :8) // __builder.AddAttribute(__seq6, "ValueChanged", __arg6) (InvocationExpression)
%60 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :481 :8) // Not a variable of known type: __builder
%61 = cbde.load %16 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :481 :31)
%62 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :481 :39) // "ValueExpression" (StringLiteralExpression)
%63 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :481 :58) // Not a variable of known type: __arg7
%64 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :481 :8) // __builder.AddAttribute(__seq7, "ValueExpression", __arg7) (InvocationExpression)
%65 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :482 :8) // Not a variable of known type: __builder
%66 = cbde.load %18 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :482 :31)
%67 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :482 :39) // "SelectedTemplate" (StringLiteralExpression)
%68 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :482 :59) // Not a variable of known type: __arg8
%69 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :482 :8) // __builder.AddAttribute(__seq8, "SelectedTemplate", __arg8) (InvocationExpression)
%70 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :483 :8) // Not a variable of known type: __builder
%71 = cbde.load %20 : memref<i32> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :483 :31)
%72 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :483 :39) // "ResultTemplate" (StringLiteralExpression)
%73 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :483 :57) // Not a variable of known type: __arg9
%74 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :483 :8) // __builder.AddAttribute(__seq9, "ResultTemplate", __arg9) (InvocationExpression)
%75 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :484 :8) // Not a variable of known type: __builder
%76 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\AddBabyGiftView.razor.g.cs" :484 :8) // __builder.CloseComponent() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
