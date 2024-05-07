public class LayeredArchitectureConfigurator {
    public CPresentationLayer ConfigureSystem() {
        var dataAccessLayer = new CDataAccessLayer();
        var applicationLayer = new CApplicationLayer(dataAccessLayer);
        var presentationLayer = new CPresentationLayer(applicationLayer);

        return presentationLayer;
    }
}