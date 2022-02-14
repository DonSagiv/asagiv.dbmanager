func @_asagiv.dbmanager.addresses.AddressDbContext.OnConfiguring$Microsoft.EntityFrameworkCore.DbContextOptionsBuilder$(none) -> () loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :42 :8) {
^entry (%_optionsBuilder : none):
%0 = cbde.alloca none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :42 :46)
cbde.store %_optionsBuilder, %0 : memref<none> loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :42 :46)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :44 :12) // base (BaseExpression)
%2 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :44 :31) // Not a variable of known type: optionsBuilder
%3 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :44 :12) // base.OnConfiguring(optionsBuilder) (InvocationExpression)
%4 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :46 :17) // Not a variable of known type: optionsBuilder
%5 = cbde.unknown : i1 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :46 :17) // optionsBuilder.IsConfigured (SimpleMemberAccessExpression)
%6 = cbde.unknown : i1 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :46 :16) // !optionsBuilder.IsConfigured (LogicalNotExpression)
cond_br %6, ^1, ^2 loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :46 :16)

^1: // SimpleBlock
%7 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :16) // Not a variable of known type: optionsBuilder
%8 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :49) // Not a variable of known type: ipAddress
%9 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :41) // $"Host={ipAddress};" (InterpolatedStringExpression)
%10 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :49 :28) // Not a variable of known type: port
%11 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :49 :20) // $"Port={port};" (InterpolatedStringExpression)
%12 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :41) // Binary expression on unsupported types $"Host={ipAddress};" +                      $"Port={port};"
%13 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :50 :32) // Not a variable of known type: database
%14 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :50 :20) // $"Database={database};" (InterpolatedStringExpression)
%15 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :41) // Binary expression on unsupported types $"Host={ipAddress};" +                      $"Port={port};" +                      $"Database={database};"
%16 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :51 :32) // Not a variable of known type: username
%17 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :51 :20) // $"Username={username};" (InterpolatedStringExpression)
%18 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :41) // Binary expression on unsupported types $"Host={ipAddress};" +                      $"Port={port};" +                      $"Database={database};" +                      $"Username={username};"
%19 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :52 :32) // Not a variable of known type: password
%20 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :52 :20) // $"Password={password}" (InterpolatedStringExpression)
%21 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :41) // Binary expression on unsupported types $"Host={ipAddress};" +                      $"Port={port};" +                      $"Database={database};" +                      $"Username={username};" +                      $"Password={password}"
%22 = cbde.unknown : none loc("B:\\Github\\asagiv.dbmanager\\asagiv.dbmanager.addresses\\AddressDbContext.cs" :48 :16) // optionsBuilder.UseNpgsql($"Host={ipAddress};" +                      $"Port={port};" +                      $"Database={database};" +                      $"Username={username};" +                      $"Password={password}") (InvocationExpression)
br ^2

^2: // ExitBlock
return

}
