import React, { Fragment } from 'react';
import { useEffect, useState } from 'react';
import { GETURL } from '../../constants/sector';

export function SectorDropDown({ callback }) {
    const [loading, setLoading] = useState(true);
    const [items, setItems] = useState([]);
    const [value, setValue] = useState('');
    useEffect(() => {
        let unmounted = false;
        async function getCharacters() {
            const response = await fetch(GETURL);
            const body = await response.json();
            // console.log(body);
            if (!unmounted) {
                setItems(
                    body.map(({ name, id, isParent, level }) => ({
                        label: name,
                        value: id,
                        isParent: isParent,
                        level: level
                    }))
                );
                setLoading(false);
            }
        }
        getCharacters();
        return () => {
            unmounted = true;
        };
    }, []);

    return (

        <Fragment>
            <label>Sectors</label>
            <select
                disabled={loading}
                value={value}
                onChange={(e) => {
                    setValue(e.currentTarget.value)
                    console.log(`value in child ${e.currentTarget.value}`)
                    callback(e.currentTarget.value)
                }}>

                {items.map(({ label, value, isParent, level }) => (
                    <option
                        key={value}
                        value={value}
                        disabled={isParent}
                        className={`${isParent ? "ddl-parent" : "ddl-child"} ${level}`}>
                        {label}
                    </option>
                ))}
            </select>
        </Fragment>
    );
}
