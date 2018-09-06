package issuetracker.bindingModel;

public class IssueBindingModel {

    private Integer id;
    private String title;
    private String content;
    private Integer priority;

    public IssueBindingModel() {
    }

    public IssueBindingModel(Integer id, String title, String content, Integer priority) {
        this.id = id;
        this.title = title;
        this.content = content;
        this.priority = priority;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public Integer getPriority() {
        return priority;
    }

    public void setPriority(Integer priority) {
        this.priority = priority;
    }
}
