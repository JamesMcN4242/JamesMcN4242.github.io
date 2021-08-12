from os import listdir
from os.path import isfile, join

def createContentJS(filePath, javaScriptPath):
    entries = [f for f in listdir(filePath) if isfile(join(filePath, f))]
    pathName = filePath.split("/")[2]       # using 2 since the folders will be in the format "../Pages/{0}/

    file = open(javaScriptPath, "w")
    file.write("function pageLoaded() {\n\tconst list = document.getElementById(\"contentList\");\n")

    for entry in entries:
        camelCaseFile = entry.split(".")[0]
        contentName = ''.join(map(lambda x: x if x.islower() else " " + x, camelCaseFile)).title()

        ulEntryName = camelCaseFile + "Ul"
        entryName = camelCaseFile + "Entry"
        nodeName = camelCaseFile + "Node"

        jsContent = "\n\tconst " + ulEntryName + " = document.createElement(\"ul\");\n"
        jsContent += "\tconst " + entryName + " = document.createElement(\"a\");\n"
        jsContent += "\tconst " + nodeName + " = document.createTextNode(\"" + contentName + "\");\n"
        jsContent += "\t" + entryName + ".appendChild(" + nodeName + ");\n"
        jsContent += "\t" + entryName + ".href = \"" + pathName + "/" + entry + "\";\n"
        jsContent += "\t" + ulEntryName + ".appendChild(" + entryName + ");\n"
        jsContent += "\tlist.appendChild(" + ulEntryName + ");\n"
        file.write(jsContent)

    file.write("}")

createContentJS("../Pages/cpp/", "../src/cppContentCreator.js")
createContentJS("../Pages/maths/", "../src/mathContentCreator.js")
