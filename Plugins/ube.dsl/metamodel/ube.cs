SYNTAXDEF ube
FOR <http://www.emftext.org/language/ube>
START EntityModel

OPTIONS{
 reloadGeneratorModel="true";
 generateCodeFromGeneratorModel="true"; //wichtig um Fehler im Generat zu vermeiden
 disableLaunchSupport="false";
 //usePredefinedTokens="true";
 resourcePluginID="ube.dsl.resource";
 resourceUIPluginID="ube.dsl.ui";
 basePackage="ube.dsl.resource";
 //srcFolder="src";
 //srcGenFolder="src-gen";
 //uiSrcFolder="src";
 //uiSrcGenFolder="src-gen";
}

RULES {
	EntityModel ::= "model" types*;
	Entity ::= abstract["abstract" : ""] "entity" name[] "{" features* "}";
	DataType ::= "datatype" name[] ";";
	Feature ::= kind[attribute:"att", reference:"ref", containment:"cont"] type[] name[] ";";
}