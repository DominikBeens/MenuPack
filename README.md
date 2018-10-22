# MenuPack
MenuPack is a custom scene manager which primary role is to load scenes asynchronously with an easy to customize transition. 
This package is built around Unity's LoadSceneAsync function and gives you a few options when loading scenes but can also load scenes instantly without any loading bar or transitions.   
It also features a pause menu and access to a basic game settings menu where you can configure things like resolution and screenmode or add your own settings if you'd like. 

All you have to do to get started is drag and drop the SceneManager prefab into your scene and it's good to go. With that prefab in your scene you can load scenes using SceneManager.instance.LoadScene().   
Don't forget to include 'using DB.MenuPack' in your script.
