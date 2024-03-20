## Library Powered By

This library is powered by [Entity Framework Extensions](https://entityframework-extensions.net/?z=github&y=entityframework-plus)

<a href="https://entityframework-extensions.net/?z=github&y=entityframework-plus">
<kbd>
<img src="https://zzzprojects.github.io/images/logo/entityframework-extensions-pub.jpg" alt="Entity Framework Extensions" />
</kbd>
</a>

---

## Setup Info for EF Classic
https://entityframework-classic.net/provider-mysql

## Setup Info for EF6

### Configuration
In the provider: `MySql.Data.Entity.EF6, Version=7.0.7.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d` must be replaced by `Z.MySql.Data.Entity.EF6, Version=8.0.0.0, Culture=neutral, PublicKeyToken=afc61983f100d280`

### From

```xml
<entityFramework>
	<defaultConnectionFactory type="MySql.Data.Entity.MySqlConnectionFactory, EntityFramework"></defaultConnectionFactory>
	<providers>
		<provider invariantName="MySql.Data.MySqlClient" type="MySql.Data.MySqlClient.MySqlProviderServices, MySql.Data.Entity.EF6, Version=7.0.7.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d"></provider>
	</providers>
</entityFramework>
```

### To

```xml
<entityFramework>
	<defaultConnectionFactory type="MySql.Data.Entity.MySqlConnectionFactory, EntityFramework"></defaultConnectionFactory>
	<providers>
		<provider invariantName="MySql.Data.MySqlClient" type="MySql.Data.MySqlClient.MySqlProviderServices, Z.MySql.Data.Entity.EF6, Version=8.0.0.0, Culture=neutral, PublicKeyToken=afc61983f100d280"></provider>
	</providers>
</entityFramework>
```

---
This is a release of MySQL Connector/NET, Oracle's fully managed ADO .NET Driver for MySQL. 

License information can be found in the LICENSE file.

This distribution may include materials developed by third parties. 
For license and attribution notices for these materials, please refer to the LICENSE file. 

For more information on MySQL Connector/NET, visit 
  http://dev.mysql.com/doc/connector-net/en/

For additional downloads and the source of MySQL Connector/NET, visit
  http://dev.mysql.com/downloads

MySQL Connector/NET is brought to you by the MySQL team at Oracle.

## Contribute

The best way to contribute is by **spreading the word** about the library:

 - Blog it
 - Comment it
 - Star it
 - Share it
 
A **HUGE THANKS** for your help.

## More Projects

- Projects:
   - [EntityFramework Extensions](https://entityframework-extensions.net/)
   - [Dapper Plus](https://dapper-plus.net/)
   - [C# Eval Expression](https://eval-expression.net/)
- Learn Websites
   - [Learn EF Core](https://www.learnentityframeworkcore.com/)
   - [Learn Dapper](https://www.learndapper.com/)
- Online Tools:
   - [.NET Fiddle](https://dotnetfiddle.net/)
   - [SQL Fiddle](https://sqlfiddle.com/)
   - [ZZZ Code AI](https://zzzcode.ai/)
- and much more!

To view all our free and paid projects, visit our website [ZZZ Projects](https://zzzprojects.com/).
