using Adapter.PowerOutlet;

USPowerOutlet usPowerOutlet = new USPowerOutlet();
IPowerOutlet usToEuAdapter = new USToEUAdapter(usPowerOutlet);
usToEuAdapter.SupplyPower(220);
