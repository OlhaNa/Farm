using Farm;
using Microsoft.Extensions.DependencyInjection;

var farmServices = new ServiceCollection(); //everything in the serviceCollection can grab anything else

farmServices.AddSingleton<Farmer>();

farmServices.AddDbContext<Farm.Farm>(); //namespace.class

var farmServicesProvider = farmServices.BuildServiceProvider();

var farmer = farmServicesProvider.GetRequiredService<Farmer>();

farmer.AddAnimal();


