function pageLoaded() {
	const list = document.getElementById("contentList");

	const crossProductIl = document.createElement("li");
	const crossProductEntry = document.createElement("a");
	const crossProductNode = document.createTextNode("Cross Product");
	crossProductEntry.appendChild(crossProductNode);
	crossProductEntry.href = "maths/crossProduct.html";
	crossProductIl.appendChild(crossProductEntry);
	list.appendChild(crossProductIl);

	const dotProductIl = document.createElement("li");
	const dotProductEntry = document.createElement("a");
	const dotProductNode = document.createTextNode("Dot Product");
	dotProductEntry.appendChild(dotProductNode);
	dotProductEntry.href = "maths/dotProduct.html";
	dotProductIl.appendChild(dotProductEntry);
	list.appendChild(dotProductIl);
}