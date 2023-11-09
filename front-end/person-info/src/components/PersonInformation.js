import { React, useState } from 'react';
import { Button, Checkbox, Form } from 'semantic-ui-react'
import axios from 'axios';
import { FormProvider, useForm } from 'react-hook-form'
import { SectorDropDown } from './shared/SectorDropDown';
import { Input } from './shared/Input';
import { POSTURL } from '../constants/personinformation';

export default function PersonInformation() {
    const methods = useForm()

    const [id, setId] = useState('');
    const [name, setName] = useState('');
    const [selectedSector, setSelectedSector] = useState(0);
    const [agreetc, setAgreeTc] = useState(false);

    const onSubmit = methods.handleSubmit(data => {

        axios.post(POSTURL, {
            name: data.Name,
            sectorId: selectedSector,
            agreeToTerms: agreetc
        })
    })

    const setTheSelectedSector = (value) => {
        console.log(`value in parent ${value}`)
        setSelectedSector(value);
    }

    return (
        <div>
            <FormProvider {...methods}>
                <Form className="create-form"
                    onSubmit={e => e.preventDefault()}
                    noValidate>

                    <Form.Field>
                        <Input
                            label="Name"
                            type="text"
                            id="name"
                            placeholder="Type your name..."
                            onChange={(e) => setName(e.target.value)}
                        />
                    </Form.Field>

                    <Form.Field>
                        <SectorDropDown
                            value={selectedSector} callback={setTheSelectedSector}
                        />
                    </Form.Field>

                    <Form.Field>
                        <Checkbox label='I agree to the Terms and Conditions' onChange={(e) => setAgreeTc(!agreetc)} />
                    </Form.Field>
                    <Button onClick={onSubmit} type='submit'>Submit</Button>
                </Form>
            </FormProvider>
        </div>
    )
}