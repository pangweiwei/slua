
require "foo"

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
end