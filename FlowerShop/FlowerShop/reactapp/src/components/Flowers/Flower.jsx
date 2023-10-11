import React from 'react';
import { useParams } from "react-router-dom";
import useGetAll from "../../hooks/useGetAll";
import _ from 'lodash';
import { urlFlowersById } from "../../urls/irlList";

const Flower = () => {
    const params = useParams()
    const [flower, loading] = useGetAll(urlFlowersById + params.id)

    const categoryTitle = _.get(flower, ['categories', '0', 'title'])
    const countryTitle = _.get(flower, ['countries', '0', 'title'])
    const imagePath = _.get(flower, ['images', '0', 'path'])
    const colorTitle = _.get(flower, ['colors', '0', 'title'])
    const count = _.get(flower, ['count', '0', '0'])
    const price = _.get(flower, ['price', '0', '0'])

    return (
        <div>
        <div className="row g-0 border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative">
            <div className="col p-4 d-flex flex-column position-static">
                <strong className="d-inline-block mb-2 text-primary-emphasis">{categoryTitle}</strong>
                <h3 className="mb-0">{flower.title}</h3>
                <p className="card-text mb-auto">Страна: {flower.countryTitle}</p>
                <p className="card-text mb-auto">Цвет: {flower.colorTitle}</p>
                <p className="card-text mb-auto">Количество: {flower.count}</p>
                <p className="card-text mb-auto">Цена: {flower.price} руб.</p>
            </div>
            <div className="col-auto d-none d-lg-block">
                <img className='bd-placeholder-img flowers-img' src={'http://localhost:5000/' + imagePath} />
            </div>
            </div>
        </div>
    )

};
export default Flower;

