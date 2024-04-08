using EntityFramework.Controllers;

SettingController settingController = new SettingController();

await settingController.GetAllAsync();

await settingController.GetById();