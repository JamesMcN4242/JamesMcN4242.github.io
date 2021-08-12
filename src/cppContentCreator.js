function pageLoaded() {
	const list = document.getElementById("contentList");

	const iteratorsUl = document.createElement("ul");
	const iteratorsEntry = document.createElement("a");
	const iteratorsNode = document.createTextNode("Iterators");
	iteratorsEntry.appendChild(iteratorsNode);
	iteratorsEntry.href = "cpp/iterators.html";
	iteratorsUl.appendChild(iteratorsEntry);
	list.appendChild(iteratorsUl);

	const lambdasUl = document.createElement("ul");
	const lambdasEntry = document.createElement("a");
	const lambdasNode = document.createTextNode("Lambdas");
	lambdasEntry.appendChild(lambdasNode);
	lambdasEntry.href = "cpp/lambdas.html";
	lambdasUl.appendChild(lambdasEntry);
	list.appendChild(lambdasUl);

	const moveSemanticsUl = document.createElement("ul");
	const moveSemanticsEntry = document.createElement("a");
	const moveSemanticsNode = document.createTextNode("Move Semantics");
	moveSemanticsEntry.appendChild(moveSemanticsNode);
	moveSemanticsEntry.href = "cpp/moveSemantics.html";
	moveSemanticsUl.appendChild(moveSemanticsEntry);
	list.appendChild(moveSemanticsUl);
}