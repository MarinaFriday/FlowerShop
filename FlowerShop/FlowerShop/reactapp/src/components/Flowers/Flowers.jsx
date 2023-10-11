import React from 'react'
import useGetAll from "../../hooks/useGetAll";
import { urlFlowers } from "../../urls/urlList";
import FlowersCatalogList from "./FlowersCatalogList";
import FlowersForm from "./FlowersForm";

const Flowers = () => {
    const [flowers, loading] = useGetAll(urlFlowers)
    if (loading) { return <h3>Загрузка</h3> }
    if (!flowers?.length) { return <h3>Список цветов пуст</h3> }
    return (
        <div>
            <FlowersForm flowers={flowers} />
            <FlowersCatalogList flowers={flowers} />
        </div>
    );
};

export default Flowers;