
# DuckHunt-Xlua #

## 要求 ##

* [Unity](https://unity3d.com/get-unity/download) v2017.2或以后

## 说明 ##

Lua编程能力基于腾讯开源框架[Xlua](https://github.com/Tencent/xLua) ，本项目是使用纯lua编写的打鸭子游戏，包含打鸭子核心玩法实现，移动端摇杆控制模块等元素。
项目已经generate code，如果报错，可以手动清空XLua/Gen文件夹下的生成代码，再手动生成。

## 举几个栗子 ##

* 基于Xlua框架，我们可以在Unity中使用lua和c#进行通讯，也即是代码热更新的基础，下面是基础的示例代码，具体完整案例参考项目工程源码。

```Lua
--定义Unity对象
function onenable()  
	unity=CS.UnityEngine
end

--定义方法
function animatorIdle()
	lionAnimator:SetTrigger("toI")
end

--调用Unity API
local ray= unity.Camera.main:ScreenPointToRay(unity.Vector3(_screenPos.x,_screenPos.y,0))
local casthit= callCS:Raycast(ray,unity.Mathf.Infinity)
if(casthit.collider) then 
	chooseObj =casthit.collider.gameObject
	print(casthit.collider.name)
end

--注册使用Unity事件
btnIdle:GetComponent("Button").onClick:AddListener(function()   end)

--注册c#自定义事件
target:GetComponent("ARBoxLuaCollision"):EventEnter('+', CheckDuckFailDown)
```

### 来看看成果吧
![](https://github.com/LQYaphets/DuckHunt-Xlua/blob/master/Assets/DuckHunt/Duck%20Hunt%20Case/Game%20Resources/duckHunt.gif)

