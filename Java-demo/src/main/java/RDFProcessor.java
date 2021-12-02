import org.apache.jena.query.*;
import org.apache.jena.rdf.model.*;
import org.apache.jena.riot.Lang;
import org.apache.jena.riot.RDFDataMgr;
import org.apache.jena.vocabulary.VCARD;

import java.io.InputStream;


public class RDFProcessor {
    //static String inputFileName = "src/main/resources/cars.rdf";
    static String inputFileName = "src/main/resources/vc-db-1.rdf";
    // static String inputFileName = "src/main/resources/stw.rdf";
    private Model model;

    public RDFProcessor() {

        readInput();
        // listStatements();
        // writeModel();
        sparql();
        // navigatingTheModel();
        // createBag();

    }

    String personURI = "http://somewhere/JohnSmith";
    String fullName = "John Smith";

    public void createOwnModel() {
        // some definitions

        // create an empty Model
        Model model = ModelFactory.createDefaultModel();

        // create the resource
        Resource johnSmith = model.createResource(personURI);

        // add the property , "constant" class VCARD
        johnSmith.addProperty(VCARD.FN, fullName);
    }


    public void readInput() {
        // create an empty model
        model = ModelFactory.createDefaultModel();

        // use the RDFDataMgr to find the input file
        InputStream inputStream = RDFDataMgr.open(inputFileName);
        if (inputStream == null) {
            throw new IllegalArgumentException(
                    "File: " + inputFileName + " not found");
        }

        // read the RDF/XML file
        model.read(inputStream, null);
    }

    public void listStatements() {
        if (model == null) {
            return;
        }
        // list the statements in the Model
        StmtIterator iter = model.listStatements();

        // only nodes with full name
        //  StmtIterator iter = model.listStatements(  new SimpleSelector((Resource) null, (Property) VCARD.FN, (RDFNode) null) );

        // print out the predicate, subject and object of each statement
        while (iter.hasNext()) {
            Statement stmt = iter.nextStatement();  // get next statement
            Resource subject = stmt.getSubject();     // get the subject
            Property predicate = stmt.getPredicate();   // get the predicate
            RDFNode object = stmt.getObject();      // get the object

            System.out.print(subject.toString());
            System.out.print(" " + predicate.toString() + " ");
            if (!(object instanceof Resource)) {

                // object is a literal
                System.out.print(" \"" + object.toString() + "\"");
            }

            System.out.println(" .");
        }
    }

    public void writeModel() {
        // write it to standard out
        model.write(System.out);

        // now write the model in a pretty form
        // RDFDataMgr.write(System.out, model, Lang.RDFXML);

        // now write the model in N-TRIPLES form, ids by Jena
        // RDFDataMgr.write(System.out, model, Lang.NTRIPLES);
    }

    public void sparql() {
        // names
        String queryString =
                "PREFIX rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#> " +
                        "PREFIX vCard:<http://www.w3.org/2001/vcard-rdf/3.0#> " +
                        "SELECT * WHERE { " +
                        " ?person vCard:FN ?x ." +
                        "}";

        // cars
//        String queryString =
//                "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#> " +
//                        " PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#> " +
//                        "SELECT ?clasa WHERE { ?clasa rdf:type rdfs:Class } ORDER BY ?clasa";

        // narrower
//        String queryString =
//                "PREFIX rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#> " +
//                        "PREFIX skos:<http://www.w3.org/2004/02/skos/core#> "+
//                        "SELECT ?narTerm WHERE { ?x skos:narrower ?narTerm } ";

        Query query = QueryFactory.create(queryString);
        try (QueryExecution queryExecution = QueryExecutionFactory.create(query, model)) {
            ResultSet resultSet = queryExecution.execSelect();
            while (resultSet.hasNext()) {
                QuerySolution querySolution = resultSet.nextSolution();
                // for names
                Literal name = querySolution.getLiteral("x");
                System.out.println(name);
                // cars & stw
                // System.out.println(querySolution);
            }
        }
    }

    public void navigatingTheModel() {
        // retrieve the John Smith vcard resource from the model
        Resource vcard = model.getResource(personURI);

        // retrieve the value of the N property
        Resource name = (Resource) vcard.getProperty(VCARD.N)
                .getObject();

        // add two nickname properties to vcard
        vcard.addProperty(VCARD.NICKNAME, "Smithy")
                .addProperty(VCARD.NICKNAME, "Johnny");

        // list the nicknames
        StmtIterator iter = vcard.listProperties(VCARD.NICKNAME);
        while (iter.hasNext()) {
            System.out.println("    " + iter.nextStatement()
                    .getObject()
                    .toString());
        }
    }

    public void createBag() {
        // create a bag
        Bag smiths = model.createBag();

        // select all the resources with a VCARD.FN property
        // whose value ends with "Smith"
        StmtIterator iter = model.listStatements(
                new SimpleSelector(null, VCARD.FN, (RDFNode) null) {
                    public boolean selects(Statement s) {
                        return s.getString().endsWith("Smith");
                    }
                });
        // add the Smith's to the bag
        while (iter.hasNext()) {
            smiths.add(iter.nextStatement().getSubject());
        }
    }
}
