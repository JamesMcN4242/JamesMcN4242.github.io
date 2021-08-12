function pageLoaded() {
	const list = document.getElementById("contentList");

	const iteratorsIl = document.createElement("li");
	const iteratorsEntry = document.createElement("a");
	const iteratorsNode = document.createTextNode("Iterators");
	iteratorsEntry.appendChild(iteratorsNode);
	iteratorsEntry.href = "cpp/iterators.html";
	iteratorsIl.appendChild(iteratorsEntry);
	list.appendChild(iteratorsIl);

	const lambdasIl = document.createElement("li");
	const lambdasEntry = document.createElement("a");
	const lambdasNode = document.createTextNode("Lambdas");
	lambdasEntry.appendChild(lambdasNode);
	lambdasEntry.href = "cpp/lambdas.html";
	lambdasIl.appendChild(lambdasEntry);
	list.appendChild(lambdasIl);

	const moveSemanticsIl = document.createElement("li");
	const moveSemanticsEntry = document.createElement("a");
	const moveSemanticsNode = document.createTextNode("Move Semantics");
	moveSemanticsEntry.appendChild(moveSemanticsNode);
	moveSemanticsEntry.href = "cpp/moveSemantics.html";
	moveSemanticsIl.appendChild(moveSemanticsEntry);
	list.appendChild(moveSemanticsIl);
}