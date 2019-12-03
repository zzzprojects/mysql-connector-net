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

Copyright (c) 2004, 2019, Oracle and/or its affiliates. All rights reserved.

This is a release of MySQL Connector/NET, Oracle's fully managed ADO .NET Driver for MySQL. 

License information can be found in the LICENSE file.

This distribution may include materials developed by third parties. 
For license and attribution notices for these materials, please refer to the LICENSE file. 

For more information on MySQL Connector/NET, visit 
  http://dev.mysql.com/doc/connector-net/en/

For additional downloads and the source of MySQL Connector/NET, visit
  http://dev.mysql.com/downloads

MySQL Connector/NET is brought to you by the MySQL team at Oracle.
