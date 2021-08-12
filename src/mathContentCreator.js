function pageLoaded() {
	const list = document.getElementById("contentList");

	const crossProductUl = document.createElement("ul");
	const crossProductEntry = document.createElement("a");
	const crossProductNode = document.createTextNode("Cross Product");
	crossProductEntry.appendChild(crossProductNode);
	crossProductEntry.href = "maths/crossProduct.html";
	crossProductUl.appendChild(crossProductEntry);
	list.appendChild(crossProductUl);

	const dotProductUl = document.createElement("ul");
	const dotProductEntry = document.createElement("a");
	const dotProductNode = document.createTextNode("Dot Product");
	dotProductEntry.appendChild(dotProductNode);
	dotProductEntry.href = "maths/dotProduct.html";
	dotProductUl.appendChild(dotProductEntry);
	list.appendChild(dotProductUl);

	const quadraticFormulaUl = document.createElement("ul");
	const quadraticFormulaEntry = document.createElement("a");
	const quadraticFormulaNode = document.createTextNode("Quadratic Formula");
	quadraticFormulaEntry.appendChild(quadraticFormulaNode);
	quadraticFormulaEntry.href = "maths/quadraticFormula.html";
	quadraticFormulaUl.appendChild(quadraticFormulaEntry);
	list.appendChild(quadraticFormulaUl);
}