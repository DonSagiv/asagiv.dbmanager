// Skipping function BuildRenderTree(none), it contains poisonous unsupported syntaxes

// Skipping function OnInitializedAsync(), it contains poisonous unsupported syntaxes

// Skipping function populateFamilies(), it contains poisonous unsupported syntaxes

// Skipping function onHeaderClicked(none), it contains poisonous unsupported syntaxes

func @_asagiv.dbmanager.webinterface.Pages.PeopleView.onAddNewPersonClick$Microsoft.AspNetCore.Components.Web.MouseEventArgs$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :459 :4) {
^entry (%_e : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :459 :36)
cbde.store %_e, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :459 :36)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :461 :8) // Not a variable of known type: navManager
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :461 :30) // "/addPersonView" (StringLiteralExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :461 :8) // navManager.NavigateTo("/addPersonView") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_asagiv.dbmanager.webinterface.Pages.PeopleView.editPerson$asagiv.dbmanager.addresses.Family$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :464 :4) {
^entry (%_family : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :464 :27)
cbde.store %_family, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :464 :27)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :466 :8) // Not a variable of known type: navManager
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :466 :47) // Not a variable of known type: family
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :466 :47) // family.familyId (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :466 :30) // $"addPersonView/{family.familyId}" (InterpolatedStringExpression)
%5 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asasgiv.dbmanager.webinterface\\obj\\Debug\\net5.0\\Razor\\Pages\\PeopleView.razor.g.cs" :466 :8) // navManager.NavigateTo($"addPersonView/{family.familyId}") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function deletePersonAsync(none), it contains poisonous unsupported syntaxes

// Skipping function filterOnKeyPressed(none), it contains poisonous unsupported syntaxes

// Skipping function onSearchClicked(), it contains poisonous unsupported syntaxes

