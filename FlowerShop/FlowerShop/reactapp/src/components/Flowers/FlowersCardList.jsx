import React from 'react';
import useGetAll from "../../hooks/useGetAll";
import { urlFlowers } from "../../urls/urlList";
import '../../styles/component/flowersCard.css'

const FlowersCardList = () => {
    const [flowers, loading] = useGetAll(urlFlowers)

    if (loading) {
        return <h3>Загрузка...</h3>
    }

    if (!flowers?.length) {
        return <h3>Список цветов пуст...</h3>
    }

    return (
        <div className="row mb-2">
            {
                flowers.map(f => (
                    <div className="col-mb-6">
                        <div className="row g-0 border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative">
                            <div className="col p-4 d-flex-column position-static">
                                <strong className="d-inline-block mb-2 text-primary-emphasis">{f.categories.map(category => (category.title))}</strong>
                                <h3 className="mb-0">{f.title}</h3>
                                <div className="mb-1 text-body-secondary">Страна: {f.countries.map(country => (country.title))}</div>
                                <div className="mb-1 text-body-secondary">Цвет: {f.colors.map(color => (color.title))}</div>
                                <div className="mb-1 text-body-secondary">Стоимость: {f.price}</div>
                                <div className="mb-1 text-body-secondary">Количество: {f.count}</div>
                            </div>
                            <div className="col-auto d-none d-lg-block">
                                <img className='bd-placeholder-img books-img' src={'http://localhost:5000/' + f.images.map(img => (img.path))} />
                            </div>
                        </div>
                    </div>                
                ))
            }
        </div>
    )

}