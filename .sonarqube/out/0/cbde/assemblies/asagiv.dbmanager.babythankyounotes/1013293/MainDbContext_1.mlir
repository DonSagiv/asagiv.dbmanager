func @_asagiv.dbmanager.babythankyounotes.MainDbContext.OnConfiguring$Microsoft.EntityFrameworkCore.DbContextOptionsBuilder$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :40 :8) {
^entry (%_optionsBuilder : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :40 :46)
cbde.store %_optionsBuilder, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :40 :46)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :42 :17) // Not a variable of known type: optionsBuilder
%2 = cbde.unknown : i1 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :42 :17) // optionsBuilder.IsConfigured (SimpleMemberAccessExpression)
%3 = cbde.unknown : i1 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :42 :16) // !optionsBuilder.IsConfigured (LogicalNotExpression)
cond_br %3, ^1, ^2 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :42 :16)

^1: // SimpleBlock
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :16) // Not a variable of known type: optionsBuilder
%5 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :49) // Not a variable of known type: _ipAddress
%6 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :41) // $"Host={_ipAddress};" (InterpolatedStringExpression)
%7 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :45 :28) // Not a variable of known type: _port
%8 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :45 :20) // $"Port={_port};" (InterpolatedStringExpression)
%9 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :41) // Binary expression on unsupported types $"Host={_ipAddress};" +                      $"Port={_port};"
%10 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :46 :32) // Not a variable of known type: _database
%11 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :46 :20) // $"Database={_database};" (InterpolatedStringExpression)
%12 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :41) // Binary expression on unsupported types $"Host={_ipAddress};" +                      $"Port={_port};" +                      $"Database={_database};"
%13 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :47 :32) // Not a variable of known type: _username
%14 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :47 :20) // $"Username={_username};" (InterpolatedStringExpression)
%15 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :41) // Binary expression on unsupported types $"Host={_ipAddress};" +                      $"Port={_port};" +                      $"Database={_database};" +                      $"Username={_username};"
%16 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :48 :32) // Not a variable of known type: _password
%17 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :48 :20) // $"Password={_password}" (InterpolatedStringExpression)
%18 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :41) // Binary expression on unsupported types $"Host={_ipAddress};" +                      $"Port={_port};" +                      $"Database={_database};" +                      $"Username={_username};" +                      $"Password={_password}"
%19 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.babythankyounotes\\MainDbContext.cs" :44 :16) // optionsBuilder.UseNpgsql($"Host={_ipAddress};" +                      $"Port={_port};" +                      $"Database={_database};" +                      $"Username={_username};" +                      $"Password={_password}") (InvocationExpression)
br ^2

^2: // ExitBlock
return

}
// Skipping function OnModelCreating(none), it contains poisonous unsupported syntaxes

