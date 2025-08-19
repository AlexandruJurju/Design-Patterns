using Adapter.PowerOutlet;

var usPowerOutlet = new USPowerOutlet();
IPowerOutlet usToEuAdapter = new USToEUAdapter(usPowerOutlet);
usToEuAdapter.SupplyPower(220);