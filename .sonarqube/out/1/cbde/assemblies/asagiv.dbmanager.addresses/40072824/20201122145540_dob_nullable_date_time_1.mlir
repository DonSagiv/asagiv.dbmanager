func @_asagiv.dbmanager.addresses.Migrations.dob_nullable_date_time.Up$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :7 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :7 :35)
cbde.store %_migrationBuilder, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :7 :35)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :9 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :10 :22) // "dateOfBirth" (StringLiteralExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :11 :23) // "Person" (StringLiteralExpression)
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :12 :22) // "timestamp without time zone" (StringLiteralExpression)
%5 = constant 1 : i1 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :13 :26) // true
%6 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :14 :28) // typeof(DateTime) (TypeOfExpression)
%7 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :15 :25) // "timestamp without time zone" (StringLiteralExpression)
%8 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :9 :12) // migrationBuilder.AlterColumn<DateTime>(                  name: "dateOfBirth",                  table: "Person",                  type: "timestamp without time zone",                  nullable: true,                  oldClrType: typeof(DateTime),                  oldType: "timestamp without time zone") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_asagiv.dbmanager.addresses.Migrations.dob_nullable_date_time.Down$Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :18 :8) {
^entry (%_migrationBuilder : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :18 :37)
cbde.store %_migrationBuilder, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :18 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :20 :12) // Not a variable of known type: migrationBuilder
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :21 :22) // "dateOfBirth" (StringLiteralExpression)
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :22 :23) // "Person" (StringLiteralExpression)
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :23 :22) // "timestamp without time zone" (StringLiteralExpression)
%5 = constant 0 : i1 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :24 :26) // false
%6 = constant 1 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :43)
%7 = constant 1 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :46)
%8 = constant 1 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :49)
%9 = constant 0 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :52)
%10 = constant 0 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :55)
%11 = constant 0 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :58)
%12 = constant 0 : i32 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :61)
// Entity from another assembly: DateTimeKind
%13 = constant unit loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :64) // DateTimeKind.Unspecified (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :25 :30) // new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) (ObjectCreationExpression)
%15 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :26 :28) // typeof(DateTime) (TypeOfExpression)
%16 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :27 :25) // "timestamp without time zone" (StringLiteralExpression)
%17 = constant 1 : i1 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :28 :29) // true
%18 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\Migrations\\20201122145540_dob_nullable_date_time.cs" :20 :12) // migrationBuilder.AlterColumn<DateTime>(                  name: "dateOfBirth",                  table: "Person",                  type: "timestamp without time zone",                  nullable: false,                  defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),                  oldClrType: typeof(DateTime),                  oldType: "timestamp without time zone",                  oldNullable: true) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
