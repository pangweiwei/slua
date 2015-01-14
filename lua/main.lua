
Vector3 = UnityEngine.Vector3
GameObject = UnityEngine.GameObject

function main()

	local go = GameObject.Find("Canvas/Button")
	local btn = go:GetComponent("Button")
	

	btn.onClick:AddListener(function()
		local go = GameObject.Find("Canvas/Text")
		local label = go:GetComponent("Text")
		label.text="hello world"
	end)
	


	local go = GameObject.Find("Canvas/Panel2"):GetComponent("ScrollRect")


	go.onValueChanged:AddListener(function(v)
		print(v.x,v.y)
	end)

	local cube = GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube)
	cube.name="Script cube"

	local pos = Vector3(10,10,10)+Vector3(1,1,1)
	cube.transform.position = pos
	cube.transform.localScale = Vector3(10,10,10)


	print(UnityEngine.PrimitiveType.Cube,type(UnityEngine.PrimitiveType.Cube))

	-- custom export
	local h=HelloWorld()
	h:say()
end