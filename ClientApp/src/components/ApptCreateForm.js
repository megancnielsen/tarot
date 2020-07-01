import React, {useState} from "react";
import { Button, Form, FormGroup, Label, Input, FormText } from 'reactstrap';
import Axios from "axios";

const INITCREATEFORM = {
    Time: Date(),
    AppointmentTimeLength: Int,
}

const ApptCreateForm = () => {
    const [form, setForm] = useState({...INITCREATEFORM});
    const handleChange = (e) => {
        setForm({...form, [etarget.id]:e.target.value});
    }
    const handleSubmit = () => {
        Axios.post("api/createappointment/", {...form}).then(result => {
            console.log(result.data);
            setForm(INITCREATEFORM);
        }).catch(err => console.log("ERROR CREATING APPT", err))
    }
    return (
        <Form>

            <FormGroup>
                <Label for="Time">Time</Label>
                <Input onChange={handleChange}value={form.Time} type="date" name="" placeholder="Time"/>
            </FormGroup>
            
            <FormGroup>
                <Label for="AppointmentTimeLength">AppointmentTimeLength</Label>
                <Input onChange={handleChange}value={form.AppointmentTimeLength} type="int" name="" placeholder="AppointmentTimeLength"/>
            </FormGroup>

            <Button onClick={handleSubmit}>Submit</Button>

        </Form>
    )
};

export default ApptCreateForm;