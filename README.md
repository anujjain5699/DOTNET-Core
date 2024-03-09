# Practice_core


Dependency Injection Services Lifetime:

ASP.NET core provides the following 3 methods to register services with the dependency injection container. The method that we use determines the lifetime of the registered service.

AddSingleton() - As the name implies, AddSingleton() method creates a Singleton service. A Singleton service is created when it is first requested.
				 This same instance is then used by all the subsequent requests. So in general, a Singleton service is created only one time per application and that single instance is used throughout the application life time.

AddTransient() - This method creates a Transient service. A new instance of a Transient service is created each time it is requested. 

AddScoped() - This method creates a Scoped service. A new instance of a Scoped service is created once per request within the scope.
			  For example, in a web application it creates 1 instance per each http request but uses the same instance in the other calls within that same web request.

