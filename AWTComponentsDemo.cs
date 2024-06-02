import java.awt.*;
import java.awt.event.*;

public class AWTComponentsDemo extends Frame implements ActionListener {
    Label nameLabel, ageLabel, genderLabel, statusLabel;
    TextField nameTextField, ageTextField;
    CheckboxGroup genderGroup;
    Checkbox maleCheckbox, femaleCheckbox;
    Button submitButton;

    public AWTComponentsDemo() {
        setTitle("AWT Components Demo");
        setSize(300, 200);
        setLayout(new GridLayout(5, 2));
        
        nameLabel = new Label("Name:");
        add(nameLabel);
        nameTextField = new TextField();
        add(nameTextField);

        ageLabel = new Label("Age:");
        add(ageLabel);
        ageTextField = new TextField();
        add(ageTextField);

        genderLabel = new Label("Gender:");
        add(genderLabel);
        genderGroup = new CheckboxGroup();
        maleCheckbox = new Checkbox("Male", genderGroup, false);
        add(maleCheckbox);
        femaleCheckbox = new Checkbox("Female", genderGroup, false);
        add(femaleCheckbox);

        statusLabel = new Label("");
        add(statusLabel);

        submitButton = new Button("Submit");
        add(submitButton);
        submitButton.addActionListener(this);

        addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent windowEvent) {
                System.exit(0);
            }
        });
    }

    public void actionPerformed(ActionEvent e) {
        String name = nameTextField.getText();
        String age = ageTextField.getText();
        String gender = maleCheckbox.getState() ? "Male" : "Female";
        
        // Assuming you have some validation logic here
        
        statusLabel.setText("Submitted: Name=" + name + ", Age=" + age + ", Gender=" + gender);
    }

    public static void main(String[] args) {
        AWTComponentsDemo demo = new AWTComponentsDemo();
        demo.setVisible(true);
    }
}